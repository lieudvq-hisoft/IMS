﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class saleStaff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SaleStaff",
                table: "Customers",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9019), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9033), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "980add70-b4bc-49e4-a454-d5acb8ea9439", new DateTime(2024, 1, 1, 16, 52, 55, 727, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 1, 1, 16, 52, 55, 727, DateTimeKind.Local).AddTicks(3723), new List<string>(), "AQAAAAIAAYagAAAAELG+oSzpwCbxOlPhHtbdePdzABAFntaNZg8jyxX2bXX7sDblrUpe5k0LgzVmL3+eQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "108e88f3-600a-4dcb-a08a-04bd63ce9c37", new DateTime(2024, 1, 1, 16, 52, 55, 794, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 1, 1, 16, 52, 55, 794, DateTimeKind.Local).AddTicks(4348), new List<string>(), "AQAAAAIAAYagAAAAEASCAFv9/imjmnTfbCmTTGhTlILsYQO1VdpBBsGlr3/bwgu4B472FXhSRWRYV9aZTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "6abbadbf-931b-47ae-977a-da4e16f8e890", new DateTime(2024, 1, 1, 16, 52, 55, 651, DateTimeKind.Local).AddTicks(843), new DateTime(2024, 1, 1, 16, 52, 55, 651, DateTimeKind.Local).AddTicks(858), new List<string>(), "AQAAAAIAAYagAAAAEDFLMZ/bGF1980z47T6GJHJDYRcTXHx7wY32biYBxziQr9csLredDoX7jNQlsNRStw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "49b26ea2-8f22-4bc0-9ad6-20ea3750d8d4", new DateTime(2024, 1, 1, 16, 52, 55, 561, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 1, 1, 16, 52, 55, 561, DateTimeKind.Local).AddTicks(7493), new List<string>(), "AQAAAAIAAYagAAAAEADtuAVKdSLgiimyN3+aMRD6a8LjpuLTJCsvO1tTvo++ptKras0BejI8wJKWq/Dtuw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(8851), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9038), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9051), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9060), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9068), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9076), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9133), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9053), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9061), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9069), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9127), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9134), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9054), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9062), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9070), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9128), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9044), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9055), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9064), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9121), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9128), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9136), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9143), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9045), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9064), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9072), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9048), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9057), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9123), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9145), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9049), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9058), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9066), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9074), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9131), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9067), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9075), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9132), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9139), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9160), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9165), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9184), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9162), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9167), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9177), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9182), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9187), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9155), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9179), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9189) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleStaff",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5366), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5381), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "3113b371-fe1b-407d-b288-e044da01deb1", new DateTime(2023, 12, 31, 23, 16, 25, 503, DateTimeKind.Local).AddTicks(6452), new DateTime(2023, 12, 31, 23, 16, 25, 503, DateTimeKind.Local).AddTicks(6463), new List<string>(), "AQAAAAIAAYagAAAAEDMqVnhFgqckYAuR343jjRnGB6f3v3uwg69gak3S6HK3fPaHLRN+MMghYE40HWPL2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7a1bec93-329d-4692-b236-0b79ddbafc20", new DateTime(2023, 12, 31, 23, 16, 25, 570, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 12, 31, 23, 16, 25, 570, DateTimeKind.Local).AddTicks(3197), new List<string>(), "AQAAAAIAAYagAAAAEBqwlhSLx++aXN4xnM+wvScw2ODlsZZO9VJ1DSBaINYF6+8gJepEdzxmR84rwFEX4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "227f6dcc-05be-4819-a58e-8f46337b72ad", new DateTime(2023, 12, 31, 23, 16, 25, 436, DateTimeKind.Local).AddTicks(5667), new DateTime(2023, 12, 31, 23, 16, 25, 436, DateTimeKind.Local).AddTicks(5678), new List<string>(), "AQAAAAIAAYagAAAAEDpZgxYmkMxqUO5Fa4kjwkT28QLgQsG+qpXSuOh+Nh1r/2hA9Lti8oqUtly2E5NQow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "d0544ebb-e305-4ae8-bec4-149afa16bf3e", new DateTime(2023, 12, 31, 23, 16, 25, 369, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 12, 31, 23, 16, 25, 369, DateTimeKind.Local).AddTicks(7469), new List<string>(), "AQAAAAIAAYagAAAAEN86uRxikN3WYiEZ365gWZqwOLO+CFHncN4p15FR5Y2D7j8H2EbiCpneRO8ZMTkdng==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5261), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5339), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5351), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5386), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5442), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5451), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5459), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5513), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5521), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5434), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5444), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5452), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5461), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5514), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5522), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5392), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5436), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5453), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5462), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5515), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5393), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5436), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5446), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5463), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5524), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5531), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5394), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5447), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5455), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5464), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5517), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5532), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5396), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5439), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5448), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5456), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5465), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5518), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5526), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5533), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5397), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5449), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5519), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5534), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5406), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5458), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5512), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5535), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5537), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5558), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5564), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5569), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5539), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5565), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5545), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5555), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5561), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5566), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5571), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5576), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5541), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5546), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5562), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5567), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5572), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5577), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5542), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5547), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5557), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5568), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5573), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5578) });
        }
    }
}