using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class customer_contact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Representator",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(347), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "cd4b60e6-f309-4f9e-9c84-d0d22e26452e", new DateTime(2023, 12, 19, 0, 15, 29, 203, DateTimeKind.Local).AddTicks(2762), new DateTime(2023, 12, 19, 0, 15, 29, 203, DateTimeKind.Local).AddTicks(2779), new List<string>(), "AQAAAAIAAYagAAAAEIyicmSoEZYG0Cq+MdUfQFJrFaT4l79jTUfhAmqrf4kNMqFpgYqFPbW0gHmtOIjMSA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a6ebcd91-fa98-45e8-bc63-8b091368f440", new DateTime(2023, 12, 19, 0, 15, 29, 281, DateTimeKind.Local).AddTicks(426), new DateTime(2023, 12, 19, 0, 15, 29, 281, DateTimeKind.Local).AddTicks(437), new List<string>(), "AQAAAAIAAYagAAAAEOf4UyqP1xgHVEa6Qkb7zXEEx3uSyyW/C4FQZJYtX2zSPDG8FyIyVEHr4h27uW/7pA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b9cbfc91-0031-4ff0-b8a9-cd420e1da6ec", new DateTime(2023, 12, 19, 0, 15, 29, 132, DateTimeKind.Local).AddTicks(484), new DateTime(2023, 12, 19, 0, 15, 29, 132, DateTimeKind.Local).AddTicks(496), new List<string>(), "AQAAAAIAAYagAAAAEAIzb/JupV36W+hY3+mpssbJWtZ8NtS9sHwkBy5g9GO1DXfZFXjrxqbFDNyHzmY7JA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7849ab1d-68dd-4b30-817b-fefcb36de348", new DateTime(2023, 12, 19, 0, 15, 29, 45, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 12, 19, 0, 15, 29, 45, DateTimeKind.Local).AddTicks(9683), new List<string>(), "AQAAAAIAAYagAAAAENy0kJZ3Rwgv78ZcBVYeaKQErewhGLkwL2WY4X2BdcNtKw6PkNIXuf1dsrYTBNaY7Q==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(197), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(307), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(397), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(448), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(458), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(485), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(493), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(501), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(468), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(477), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(486), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(494), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(502), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(413), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(452), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(461), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(469), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(479), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(495), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(503), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(453), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(462), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(480), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(488), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(496), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(454), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(472), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(480), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(489), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(546), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(455), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(481), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(490), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(456), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(465), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(482), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(491), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(499), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(548), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(447), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(457), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(475), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(483), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(492), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(549), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(557), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(562), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(567), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(572), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(577), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(582), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(587), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(558), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(563), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(568), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(573), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(578), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(583), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(588), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(554), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(564), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(569), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(574), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(579), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(584), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(589), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(555), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(560), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(570), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(575), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(580), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(585), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(590), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(556), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(561), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(566), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(571), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(576), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(581), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(586), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(591), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(591) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Representator",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5812), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5829), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "89edeb27-5947-4a7a-92f2-7fddcb71f471", new DateTime(2023, 12, 18, 17, 44, 9, 758, DateTimeKind.Local).AddTicks(7875), new DateTime(2023, 12, 18, 17, 44, 9, 758, DateTimeKind.Local).AddTicks(7896), new List<string>(), "AQAAAAIAAYagAAAAEDk0UB5DPxb6yZALmrAwLquvw+K9Wj/hoenzj5zg/a2uQdO2damCUQupvSZWosP4EQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "fa3f7750-a69a-47cf-8a85-f1ee1d42b279", new DateTime(2023, 12, 18, 17, 44, 9, 913, DateTimeKind.Local).AddTicks(581), new DateTime(2023, 12, 18, 17, 44, 9, 913, DateTimeKind.Local).AddTicks(594), new List<string>(), "AQAAAAIAAYagAAAAELWvJ/d8E+p2zD5vG2GQWozDXz47ahpSBeCcg/JpyiaLarZhMoW9M8N+DuGBLp5XJg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "dbce37c1-21c7-4e8b-84e1-50c60ef22f00", new DateTime(2023, 12, 18, 17, 44, 9, 395, DateTimeKind.Local).AddTicks(6596), new DateTime(2023, 12, 18, 17, 44, 9, 395, DateTimeKind.Local).AddTicks(6643), new List<string>(), "AQAAAAIAAYagAAAAEBfL2PY7Qpc4qx73pVhhRFfqxbeAniQ/qv9aiA4Hmh5aWgNgK+HwivBo/PQt388yDg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "75f31eea-33f5-4485-a2f1-543792fda839", new DateTime(2023, 12, 18, 17, 44, 9, 25, DateTimeKind.Local).AddTicks(6474), new DateTime(2023, 12, 18, 17, 44, 9, 25, DateTimeKind.Local).AddTicks(6510), new List<string>(), "AQAAAAIAAYagAAAAEBgZ60H4CfRlv5HKUkBNHbWqvE3mdEvoabsPf+JNnkim5qzy9Ewe89qkSHu2ZbV3Bg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5503), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5769), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5779), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5895), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5941), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5955), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5987), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5846), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5929), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5944), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5959), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5991), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5848), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5946), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5995), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5903), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5947), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5967), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5999), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5866), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5905), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5870), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5936), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5950), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5975), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6024), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5891), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5923), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5952), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5979), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5909), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5939), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5953), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5983), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6058), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6071), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6079), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6090), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6107), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6125), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6145), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6152), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6064), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6072), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6080), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6093), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6129), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6146), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6156), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6082), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6096), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6114), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6133), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6159), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6083), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6100), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6118), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6136), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6149), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6163), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6069), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6077), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6086), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6121), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6150), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6167), new DateTime(2023, 12, 18, 17, 44, 9, 21, DateTimeKind.Local).AddTicks(6168) });
        }
    }
}
