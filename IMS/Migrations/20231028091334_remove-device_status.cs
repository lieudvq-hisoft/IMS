using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class removedevice_status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Devices");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6659), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6675), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80c69b65-7084-4d54-a130-6ba134b20126", "AQAAAAIAAYagAAAAEAtTzzxCQgU5T4ceD9bQbBoJUySMf0ZN0oheZOLlqUb6RJH5Atd4QEq1kFi+TWhNiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e27ac1a-6ecc-4849-88da-090bcc6c350d", "AQAAAAIAAYagAAAAEBvtAdL822grEpnBaeSaOvyRlGT+780pPfr/J/FS32qNmNbZs/G+sExyy8pYIFnjgw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2eed0a22-4f2a-43d1-95d3-07850c5d61a7", "AQAAAAIAAYagAAAAEOKTnmaN8JlER3W5iI1Iyj4WfOslHIBoM4BfC1qD0hoyBkFUMs5BSOaKvkz1l/uZTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebf54b2a-93c4-4e98-b81a-b227e51ee7ac", "AQAAAAIAAYagAAAAEFm4e83l951GMi2ADatY3n6fNTxIb7gKUsHILemHKF3XaYv3Jcd8eIqSNmwBH9cUgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1090caed-e7d2-4aae-8047-950e8c2e3ebb", "AQAAAAIAAYagAAAAECldeXYousVN1LWtzIs48BznIlmblY3RBwubRBCL9fVshVb6FYZG2+fHn5lMWF287w==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6487), new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6578), new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6596), new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6556), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6629), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7649), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7728), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7808), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7841), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7852), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7901), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7922), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8095), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8146), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8157), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8167), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8178), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8189), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8199), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8210), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8231), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8241), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8284), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8296), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8307), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8330), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8351), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8372), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8383), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8404), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8414), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8425), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8435), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8447), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8457), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8467), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8478), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8488), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8499), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8521), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8531), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8592), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8605), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8615), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8636), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8646), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8657), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8667), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8677), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8688), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8699), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8782), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8812), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8877), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8941), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8951), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8992), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9002), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9013), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9023), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9033), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9044), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9055), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9065), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9075), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9085), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9106), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9116), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9126), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9136), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9147), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9157), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9238), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9251), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9261), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9271), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9281), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9292), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9302), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9313), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9323), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9334), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9344), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9355), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9366), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9386), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9396), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9406), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9417), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9427), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9438), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9448), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9459), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9512), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9545), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9566), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9577), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9587), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9598), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9608), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9619), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9629), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9639), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9680), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9691), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9712), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9743), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9753), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9764), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9821), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9842), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9853), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9863), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9874), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9885), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9927), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9937), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9957), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9988), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(8), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(18), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(39), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(49), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(59), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(68), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(100), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(155), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(165), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(175), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(186), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(196), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(207), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(218), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(248), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(258), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(289), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(300), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 10, 28, 16, 13, 33, 809, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7574), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7606), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7630), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6683), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6699), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6785), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6807), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6817), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6825), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6689), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6701), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6787), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6818), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6826), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6702), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6788), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6801), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6811), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6827), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6836), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6691), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6722), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6789), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6802), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6812), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6820), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6829), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6693), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6724), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6795), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6803), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6830), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6696), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6804), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6814), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6831), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6839), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6697), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6782), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6797), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6823), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6698), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6784), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6798), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6806), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6816), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6833), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6841), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6843), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6850), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6855), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6866), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6902), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6907), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6845), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6851), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6861), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6903), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6909), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6914), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6847), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6857), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6899), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6915), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6853), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6858), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6864), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6900), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6905), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6911), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6916), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6854), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6859), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6901), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6912), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6917), new DateTime(2023, 10, 28, 16, 13, 33, 808, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6618), new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6641), new DateTime(2023, 10, 28, 16, 13, 33, 469, DateTimeKind.Local).AddTicks(6642) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Devices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4197), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98a9ac2d-496d-4cfb-8493-ba025aa1f8a2", "AQAAAAIAAYagAAAAEMDf9j5Mr1asbhyz3SZ0OGIt1QgspB0k8psOp2eNHmlT5j7Pnv4OAOAahBOOlRRoYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0fb061c-9590-48d8-8f7f-b4443508ce26", "AQAAAAIAAYagAAAAEO6b0VdYNUvTtRNf4ye1PgKuw29zZI5cAlEwVrA6xuMl+M1CKmOtkXMQtkK9mDeqMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "581bd23a-4b6e-4d3e-b7c9-6ff9360b5828", "AQAAAAIAAYagAAAAEBejD8caHhUGSDzMny83128IuRDmEaypuS6d0ePizGQr272iOryeDn/NVOTv9MTiNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30484e0b-cd78-4d1e-a236-129b3e80b5ee", "AQAAAAIAAYagAAAAELNOR0sv6qAMgCWX4uFbNFCJ1jbXiEcLhsaKuyWKgHZSCXfyHS6l2p4AFOeVDfTXeA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fab9d05-562e-4f2e-9fb3-1fa4cd898e52", "AQAAAAIAAYagAAAAELFbZNcU9ZtD9kBPexdMAzgjl0qD7dpYurSkcoXVkHkh35XWzlzC3k65ndvNhN0CmA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1489), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1868), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1892), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1914), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4157), 0 });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(486), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(516), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(803), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(830), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(847), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(862), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(876), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(911), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(927), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(941), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(956), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(972), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1001), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1019), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1034), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1049), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1064), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1081), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1152), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1165), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1181), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1198), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1213), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1383), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1440), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1458), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1475), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1493), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1508), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1554), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1590), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1625), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1671), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1746), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1795), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1831), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1936), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1969), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2001), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2371), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2393), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2419), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2431), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2456), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2499), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2523), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2584), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2619), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2796), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2941), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2951), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2962), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2982), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3033), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3084), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3094), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3124), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3154), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3288), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3343), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3353), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3363), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3374), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3384), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3394), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3404), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3455), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3471), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3485), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3501), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3518), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3532), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3731), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3747), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3763), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3859), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3885), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3919), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4150), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4187), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4208), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4241), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4289), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4306), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4321), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4354), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4371), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4389), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4424), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4643), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4661), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4679), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4695), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4712), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4743), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4839), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4901), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4927), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4945), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4979), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5013), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5108), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5119), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5153), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5164), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5446), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5468), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5478), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5488), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5499), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5509), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5519), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5539), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(451), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4235), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4279), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4591), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4615), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4663), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4251), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4284), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4569), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4643), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4688), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4573), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4598), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4623), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4646), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4668), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4691), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4290), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4576), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4649), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4694), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4263), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4292), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4579), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4652), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4697), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4269), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4581), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4654), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4677), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4634), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4657), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4679), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4703), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4275), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4301), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4587), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4637), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4660), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4682), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4711), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4729), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4772), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5011), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5025), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4717), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4732), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4746), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4761), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4775), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5014), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4735), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4750), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4764), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4778), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5017), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5031), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4738), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4752), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4766), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4989), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5006), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5020), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4726), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4741), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4755), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4993), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5008), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5022), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5036), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1963), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1993), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(2017), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(2018) });
        }
    }
}
