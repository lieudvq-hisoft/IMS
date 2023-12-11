using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class entitiesNotification1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8530), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "bcd397e1-565a-4498-ac1e-15e887f4f1f6", new DateTime(2023, 12, 11, 10, 31, 46, 166, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 12, 11, 10, 31, 46, 166, DateTimeKind.Local).AddTicks(8660), new List<string>(), "AQAAAAIAAYagAAAAEKqNoAFgP5PtKtZ/5oLr2gl5+xHO3wfiIxHSouse5p7dnGEgfxbqhXmzCshfNRxhXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "94423a07-f202-4e44-97b3-964d2a01f7e9", new DateTime(2023, 12, 11, 10, 31, 46, 205, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 12, 11, 10, 31, 46, 205, DateTimeKind.Local).AddTicks(500), new List<string>(), "AQAAAAIAAYagAAAAEEaGAP3MzFbu4iYifEIAO/pkGufn4K8gsgrsPuoQ+0rgMGGqV9sltVlOn07G8ze0HA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "383f0a0a-a495-4803-b5e4-cbda3d4dced2", new DateTime(2023, 12, 11, 10, 31, 46, 128, DateTimeKind.Local).AddTicks(5380), new DateTime(2023, 12, 11, 10, 31, 46, 128, DateTimeKind.Local).AddTicks(5390), new List<string>(), "AQAAAAIAAYagAAAAEDk2QkBo4KfrNl3+o/o+m1jO3NAeFYJUly9u+y1OGgphPOrW0LRJE54lhP5Ya7YD0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c71f51b2-ade9-4399-b769-464ccdccc881", new DateTime(2023, 12, 11, 10, 31, 46, 90, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 12, 11, 10, 31, 46, 90, DateTimeKind.Local).AddTicks(5100), new List<string>(), "AQAAAAIAAYagAAAAEDLHxDTcImzDcuUop+HoTLafn7mBFN7rcmp4xlhy9/o0vO8tS2XgWj7wjyCVZvowhg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 12, 11, 10, 31, 46, 87, DateTimeKind.Local).AddTicks(8730) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "5ab0f581-3d23-46fd-b21f-4501b12f1a3d", new DateTime(2023, 12, 11, 10, 29, 52, 54, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 12, 11, 10, 29, 52, 54, DateTimeKind.Local).AddTicks(7810), null, "AQAAAAIAAYagAAAAEKYP49FfFFlrvlFVxGOfZZum2WF0CkMWSWlu7iyxVWL4z5g+2fuXJ8s0CoF8q/PcQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "9b7588bd-09b1-4825-bb2d-b7a86b77f85a", new DateTime(2023, 12, 11, 10, 29, 52, 94, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 12, 11, 10, 29, 52, 94, DateTimeKind.Local).AddTicks(120), null, "AQAAAAIAAYagAAAAEPZIDsA7X5J4gQEp8qpOSa8nWdjrg5B3zv2HryJxONYrkf4JZK1Jd07mrbYWYBIBqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "134159c5-30d0-4b4b-b1df-911afeff1f5c", new DateTime(2023, 12, 11, 10, 29, 52, 10, DateTimeKind.Local).AddTicks(9640), new DateTime(2023, 12, 11, 10, 29, 52, 10, DateTimeKind.Local).AddTicks(9680), null, "AQAAAAIAAYagAAAAELd9gxYmRAH2LbdBqyUXYJF6i6PGnRFBboopa162SpvAu5o34i6tiGJ4jAFiLoCimA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "cb1384b8-c6b6-40d6-9709-4e45f3a4255f", new DateTime(2023, 12, 11, 10, 29, 51, 971, DateTimeKind.Local).AddTicks(3180), new DateTime(2023, 12, 11, 10, 29, 51, 971, DateTimeKind.Local).AddTicks(3180), null, "AQAAAAIAAYagAAAAEGnyu3fvg3elrtVsnkDJH+K6/buoRwfB7Y+wzzQ1Oa+KmFqmKuqGe0WS2jhgwYLzEQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010) });
        }
    }
}
