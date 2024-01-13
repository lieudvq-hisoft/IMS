using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(6992), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7005), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "isDeactive" },
                values: new object[] { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), null, "Manager", "Manager", null, false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7132877a-8a7c-4921-ad67-f7ca0601ace4", new DateTime(2024, 1, 13, 10, 17, 31, 147, DateTimeKind.Local).AddTicks(6037), new DateTime(2024, 1, 13, 10, 17, 31, 147, DateTimeKind.Local).AddTicks(6053), new List<string>(), "AQAAAAIAAYagAAAAEFJMbPHiaYHDI/qz+gkP7jsNbw2V4TDX528jfxjvj42AYzYawhI7bBkpl93fq4WA9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a99b029d-3011-4fdf-975e-e025c94a9e3e", new DateTime(2024, 1, 13, 10, 17, 31, 227, DateTimeKind.Local).AddTicks(5223), new DateTime(2024, 1, 13, 10, 17, 31, 227, DateTimeKind.Local).AddTicks(5242), new List<string>(), "AQAAAAIAAYagAAAAEAekIpUQio4ZjPGY11ljgWfXsq+JDZhFwvp0F8q51cwRH67eTmpCoP3fXolnTQ5oQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "421737a0-9ca0-4e2a-a1f3-2f7253f19474", new DateTime(2024, 1, 13, 10, 17, 31, 70, DateTimeKind.Local).AddTicks(9427), new DateTime(2024, 1, 13, 10, 17, 31, 70, DateTimeKind.Local).AddTicks(9439), new List<string>(), "AQAAAAIAAYagAAAAEL9GhEP35K9PAJ9UNB5Oy3uLHewtXh6Rn7FQbUnbK1o7CCAy0qo7O1smv6y+vtVt/A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b64ad94f-a73c-4f2b-ae67-65ce2b917474", new DateTime(2024, 1, 13, 10, 17, 30, 994, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 1, 13, 10, 17, 30, 994, DateTimeKind.Local).AddTicks(1189), new List<string>(), "AQAAAAIAAYagAAAAEC25VGLCh9onl5GY+IdS9ZUzIRnDi3LczLXKAdMbHEBPaYKFrWiTP+stuwsJ8PhJ2g==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CurrenNoticeCount", "DateCreated", "DateUpdated", "Email", "EmailConfirmed", "FcmTokens", "Fullname", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"), 0, "Tòa S106 Vinhomes Grand Park, TP. Thủ Đức, TP. Hồ Chí Minh", "d1a126bf-b29b-439e-ab9d-178f98bf2762", 0, new DateTime(2024, 1, 13, 10, 17, 31, 317, DateTimeKind.Local).AddTicks(3392), new DateTime(2024, 1, 13, 10, 17, 31, 317, DateTimeKind.Local).AddTicks(3404), "oanh.tongo@gmail.com", true, new List<string>(), "Ngô Tố Oanh", false, false, null, "oanh.tongo@gmail.com", "oanh.tongo", "AQAAAAIAAYagAAAAEIJlJNWIY6JwGah3ZMjmpBpOzyTwFov0MQWi9O5Vt6CtxkKaTjUQp46LMVXsklKKNA==", "0682716311", false, "", false, "oanh.tongo" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(6797), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(6957), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(6970), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7012), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7051), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7060), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7068), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7075), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7123), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7124), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7131), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7138), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7138), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7016), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7016), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7052), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7061), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7061), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7069), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7077), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7125), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7132), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7132), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7139), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7139), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7017), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7053), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7053), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7062), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7070), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7078), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7125), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7125), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7133), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7140), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7018), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7054), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7054), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7063), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7070), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7071), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7118), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7118), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7126), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7134), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7141), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7141), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7019), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7019), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7056), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7064), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7064), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7072), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7120), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7127), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7127), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7134), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7135), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7142), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7142), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7023), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7056), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7065), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7065), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7073), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7120), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7121), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7128), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7136), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7143), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7143), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7033), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7034), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7058), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7066), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7073), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7073), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7122), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7129), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7129), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7136), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7136), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7144), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7034), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7040), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7059), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7067), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7074), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7074), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7122), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7123), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7130), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7130), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7137), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7145), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7146), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7146), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7152), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7153), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7158), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7162), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7167), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7172), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7177), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7181), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7149), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7154), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7159), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7163), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7163), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7168), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7168), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7172), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7173), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7178), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7182), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7150), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7155), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7160), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7164), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7164), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7169), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7169), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7174), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7178), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7183), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7151), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7156), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7160), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7165), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7165), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7170), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7174), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7175), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7179), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7184), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7184), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7152), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7157), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7161), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7161), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7166), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7166), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7171), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7175), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7176), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7180), 6000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7184), new DateTime(2024, 1, 13, 10, 17, 30, 990, DateTimeKind.Local).AddTicks(7185), 6000 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"));

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
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1233), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1234), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1264), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1359), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1359), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1367), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1368), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1375), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1375), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1383), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1384), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1391), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1399), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1247), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1247), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1265), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1270), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1361), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1361), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1368), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1369), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1376), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1377), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1384), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1385), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1392), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1392), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1400), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1249), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1280), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1281), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1362), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1369), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1370), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1377), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1378), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1385), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1385), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1393), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1400), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1249), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1250), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1282), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1363), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1371), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1378), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1379), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1386), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1386), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1394), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1401), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1401), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1250), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1251), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1283), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1283), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1363), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1364), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1371), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1379), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1379), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1387), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1387), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1394), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1395), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1402), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1253), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1253), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1283), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1284), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1364), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1365), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1372), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1372), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1381), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1388), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1388), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1395), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1396), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1403), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1403), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1254), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1255), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1285), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1366), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1366), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1373), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1381), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1382), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1389), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1389), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1396), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1396), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1404), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1404), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1255), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1256), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1358), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1358), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1366), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1367), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1374), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1382), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1383), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1390), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1390), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1397), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1398), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1405), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1405), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1406), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1406), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1413), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1417), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1417), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1422), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1427), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1427), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1432), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1432), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1504), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1509), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1509), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1409), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1413), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1414), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1418), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1418), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1423), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1428), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1433), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1433), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1505), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1506), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1510), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1409), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1410), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1414), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1414), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1419), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1419), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1424), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1429), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1434), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1434), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1506), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1507), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1511), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1511), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1411), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1415), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1415), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1420), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1425), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1430), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1435), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1435), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1507), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1512), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1512), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1411), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1412), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1416), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1416), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1421), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1421), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1426), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1426), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1431), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1436), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1436), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1508), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1508), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1513), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1513), 3500 });
        }
    }
}
