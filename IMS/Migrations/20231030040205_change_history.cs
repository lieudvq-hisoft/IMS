using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_history : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "ColocationHistories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProposedDateStop",
                table: "ColocationHistories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3525), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3534), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3ece8ed-8dd6-4ff0-9c85-f30a0d4df8dc", "AQAAAAIAAYagAAAAEE+0RMDkjw+qj+CWbFiqN0HB7OK9NDt8dLmnDAddpPgexPFiAMvwd5KOqzJNgbphLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d65c3228-0f4d-46a8-a765-e66688fdeaab", "AQAAAAIAAYagAAAAECjBi/D/lNA1r8gBGqoIa0ANuy05K3rgv3QoLCTM5W4/C351RqDXqXD47wajscw96A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7750842d-2167-4653-919d-efb1205997ee", "AQAAAAIAAYagAAAAEGwGYjQLA1EN+JzSPodvQqyzN1iwpZCbtLC0M1gAviWvBHhTb1T5C4tJCMphoUrOBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f662e81-7e53-4cfd-8945-77cc94f5de30", "AQAAAAIAAYagAAAAEOAsTe5jcQMlBcj7F5V5MNR3EXLZV7N0T2+zBb+Oow6Pu0nXvEFWUjB293T4qdq0tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ec26252-cf80-465b-9d4b-b252d0fa1d24", "AQAAAAIAAYagAAAAEC0qC2aKchv8Su8wzpT5cCjjDgReCnsHeOliVP5kfQakbxfUnJ3QYDrEHjSA0biM5Q==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6278), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6366), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6375), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6385), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3503), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4388), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4392), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4399), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4402), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4412), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4416), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4419), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4422), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4425), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4429), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4435), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4446), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4449), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4452), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4465), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4476), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4483), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4486), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4489), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4498), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4505), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4508), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4512), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4515), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4518), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4524), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4531), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4537), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4543), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4547), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4550), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4553), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4556), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4569), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4572), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4591), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4594), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4613), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4622), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4635), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4638), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4641), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4661), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4664), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4667), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4677), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4683), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4686), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4693), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4696), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4699), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4702), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4734), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4737), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4740), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4747), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4750), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4753), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4756), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4759), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4762), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4765), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4768), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4772), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4781), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4784), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4793), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4796), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4800), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4809), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4812), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4815), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4834), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4837), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4843), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4846), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4849), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4852), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4855), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4858), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4871), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4874), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4877), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4896), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4912), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4915), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4918), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4921), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4924), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4928), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4931), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4934), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4949), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4952), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4955), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4958), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4961), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4965), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4968), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4971), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4974), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4977), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4980), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4983), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4986), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4989), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5009), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5015), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5018), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5021), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5024), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5031), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5043), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5047), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5050), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5056), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5059), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5062), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5072), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5078), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5088), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5091), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4324), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4348), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4356), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3541), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3582), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3590), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3605), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3612), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3619), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3548), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3583), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3592), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3599), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3606), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3613), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3620), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3584), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3593), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3600), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3607), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3614), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3576), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3586), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3594), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3601), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3577), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3587), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3594), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3609), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3616), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3630), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3588), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3595), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3610), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3631), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3580), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3596), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3603), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3611), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3581), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3597), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3604), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3612), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3634), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3640), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3696), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3701), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3705), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3709), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3718), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3636), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3641), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3697), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3701), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3706), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3710), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3719), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3637), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3642), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3698), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3702), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3707), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3711), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3715), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3720), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3648), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3699), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3703), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3712), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3716), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3721), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3649), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3700), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3704), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3713), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3717), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3722), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6407), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6431), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6431) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "ColocationHistories");

            migrationBuilder.DropColumn(
                name: "ProposedDateStop",
                table: "ColocationHistories");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "342aae49-4786-45a8-84c9-acf24de20cbd", "AQAAAAIAAYagAAAAEMAGor9hrRfmIai1oT04kXh0ugEL1IjgNKSJlreI9JJ8lXl6Rq3Lx/Q0lCvPiF+HwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a48456e3-c975-4639-9dc3-ff4b51ad7e09", "AQAAAAIAAYagAAAAENh4YEb2CpmSNPHAINv/NX6auIshJWBhqY1BBZEBRXj6NnCGP0W7NzIiv2d6jCvqrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40755d8d-7d3d-411d-91a1-f3b1e8e43a6b", "AQAAAAIAAYagAAAAEKH5O7WYHQVOuYPwPF2fbjGvFdSsZGeQWifWYF2T6vrmPi6W/O5D5VcmKh1IuoekRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f21e836-e056-48f7-a8ad-a53cf2c41f62", "AQAAAAIAAYagAAAAEPOtUvWfxC8C7AKIuesj6iwx5m9XJUq/nawJ2yX2qQzQYv7QfhTxBdepUc0/yZGePQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16b6b675-d889-4b26-9feb-2fe382e9b772", "AQAAAAIAAYagAAAAEIHDbMyfTF4RGxUfGnvHgdViZ0ZXV3clPBDyEFc7awGmbX9UnV+PXALGE7BRON8uhA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7008), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7131), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7158), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7203), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7235), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9863), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9871), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9882), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9899), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9908), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9915), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9921), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9925), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9928), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9940), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9943), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9946), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9949), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9952), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9999), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(2), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(8), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(11), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(14), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(17), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(32), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(38), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(41), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(47), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(50), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(56), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(59), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(63), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(66), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(69), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(72), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(75), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(78), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(85), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(91), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(94), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(97), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(105), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(109), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(112), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(118), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(124), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(127), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(130), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(133), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(139), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(142), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(145), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(151), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(154), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(157), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(185), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(188), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(192), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(195), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(198), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(201), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(204), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(207), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(221), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(225), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(231), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(234), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(237), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(240), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(244), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(247), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(250), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(253), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(256), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(259), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(271), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(281), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(284), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(296), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(326), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(329), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(336), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(342), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(345), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(348), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(351), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(357), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(369), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(372), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(380), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(390), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(396), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(402), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(408), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(411), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(418), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(433), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(436), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(439), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(446), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(449), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(452), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(455), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(458), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(461), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(472), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(475), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(478), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(481), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(484), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(490), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(493), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(503), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(509), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(515), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(530), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(537), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(543), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(546), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(549), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9823), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9842), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9850), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9107), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9114), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9122), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9129), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9137), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9081), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9100), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9108), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9116), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9123), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9130), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9137), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9083), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9093), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9101), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9109), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9124), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9131), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9138), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9084), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9102), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9125), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9132), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9139), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9085), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9095), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9103), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9118), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9126), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9133), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9140), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9087), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9104), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9119), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9127), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9134), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9141), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9088), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9105), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9120), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9128), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9135), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9142), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9089), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9097), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9106), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9121), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9128), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9136), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9143), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9144), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9157), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9162), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9167), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9175), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9153), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9158), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9163), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9167), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9172), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9176), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9181), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9185), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9159), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9164), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9173), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9177), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9155), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9169), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9174), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9156), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9161), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9170), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9174), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9179), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9188), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7299), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7336), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7357) });
        }
    }
}
