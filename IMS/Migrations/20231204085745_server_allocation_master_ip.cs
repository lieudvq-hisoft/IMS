using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class server_allocation_master_ip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IpMaster",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5583), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3ad7d425-a2a1-44b8-bda0-c9b667da2995", new DateTime(2023, 12, 4, 15, 57, 44, 678, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 12, 4, 15, 57, 44, 678, DateTimeKind.Local).AddTicks(1243), "AQAAAAIAAYagAAAAEKpMIiBI761d1TeN/2bGhWEKkEeYCaP0LKd2AKyog8ruWgXoE5YzOB6Kel/3IEcONg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "75adc9c0-33b9-47d5-91e7-def7ae1771c4", new DateTime(2023, 12, 4, 15, 57, 44, 482, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 12, 4, 15, 57, 44, 482, DateTimeKind.Local).AddTicks(1830), "AQAAAAIAAYagAAAAEADrMyrTB8NdtN5O5tzXFYaWj4p1ywq7U51kzYW2SA5KkZbtDREOhYVBKXfU99Vnig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "800a44ac-055b-4a68-9735-315889982e17", new DateTime(2023, 12, 4, 15, 57, 44, 566, DateTimeKind.Local).AddTicks(4883), new DateTime(2023, 12, 4, 15, 57, 44, 566, DateTimeKind.Local).AddTicks(4896), "AQAAAAIAAYagAAAAEH5yAijHCWtno8CHKLIVcSjlA8V8F35YgMqeDQtJpYTNgXwVYqzOPDj3FU1pA+gAtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "58a16c70-b571-41e6-a65d-ff47fa246729", new DateTime(2023, 12, 4, 15, 57, 44, 410, DateTimeKind.Local).AddTicks(20), new DateTime(2023, 12, 4, 15, 57, 44, 410, DateTimeKind.Local).AddTicks(33), "AQAAAAIAAYagAAAAEH9eaBQpTS8QiaIvxL/LB+kufMrS9FloHjMgCd/vbY6y8VLEWB6/K59faSI7RWybIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b1ca7c4f-9386-4c3b-b6bc-10b34d06ab3c", new DateTime(2023, 12, 4, 15, 57, 44, 326, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 12, 4, 15, 57, 44, 326, DateTimeKind.Local).AddTicks(7903), "AQAAAAIAAYagAAAAEO0eRu/t/rHGsvkrSj80Y4Jxu7QGAW5uNFwbG0bLWYTICnakDpi/ZKYtERxk+Ea+wg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5428), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5535), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5562), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5643), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5699), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5724), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5732), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5739), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5645), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5709), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5740), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5646), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5702), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5726), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5741), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5618), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5711), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5719), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5727), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5734), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5742), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5648), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5704), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5735), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5743), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5649), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5705), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5713), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5736), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5744), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5641), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5650), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5706), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5737), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5745), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5642), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5707), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5738), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5746), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5747), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5753), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5758), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5763), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5768), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5772), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5848), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5749), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5754), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5759), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5764), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5769), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5773), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5755), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5765), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5774), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5751), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5766), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5775), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5757), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5762), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5767), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5771), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5846), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5851), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5856) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IpMaster",
                table: "ServerAllocations");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8519), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "713c19f4-139e-40de-9dc8-bfaddf856014", new DateTime(2023, 12, 4, 10, 46, 3, 758, DateTimeKind.Local).AddTicks(446), new DateTime(2023, 12, 4, 10, 46, 3, 758, DateTimeKind.Local).AddTicks(458), "AQAAAAIAAYagAAAAEM5sUahe+ZArSCeSn/uotd+Nku2zt5WkkFg6mSjwoXopZ0uzowLd3q9Y5shxzyWQIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ed66ffa7-aee5-4b7d-87bf-f5d54f622a16", new DateTime(2023, 12, 4, 10, 46, 3, 607, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 12, 4, 10, 46, 3, 607, DateTimeKind.Local).AddTicks(4446), "AQAAAAIAAYagAAAAEHg+Yb1PAKzI+Rt0HlCj6ObdLR3VQWDNKiAA7ccE7GbnDsuGXj08qMJAbk3xPRAAFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bbdc3c0c-7f11-4a77-b111-f0021e3c3fb3", new DateTime(2023, 12, 4, 10, 46, 3, 681, DateTimeKind.Local).AddTicks(8681), new DateTime(2023, 12, 4, 10, 46, 3, 681, DateTimeKind.Local).AddTicks(8692), "AQAAAAIAAYagAAAAEPDKzlvRlK3vo/ukcAvxnl8fn0kMkw/pxJewg5m9QdS+xxKgnIJJ9wXMrzdJsJHsoQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bb813f0e-8dfd-4e1c-a8b9-8bc01fe0781b", new DateTime(2023, 12, 4, 10, 46, 3, 529, DateTimeKind.Local).AddTicks(9366), new DateTime(2023, 12, 4, 10, 46, 3, 529, DateTimeKind.Local).AddTicks(9380), "AQAAAAIAAYagAAAAELuHW+IqMfbdbstxdoiD1Iz1Z/LnY/Wcua+XHYIkJiHCYnC1PYEzLMfqGaCLjMLedg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "592078f8-8d56-4ce8-a34f-ad1793689326", new DateTime(2023, 12, 4, 10, 46, 3, 461, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 12, 4, 10, 46, 3, 461, DateTimeKind.Local).AddTicks(9821), "AQAAAAIAAYagAAAAEBhel3Cp6RnNZ7J3eFW4WXN5nAbMBBeHqMu8JcHJKdcDsxJSVFkUrTsD/n6Ci98VBQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8306), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8434), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8447), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8459), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8471), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8485), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8525), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8589), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8597), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8605), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8613), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8621), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8534), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8573), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8599), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8606), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8614), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8622), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8536), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8583), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8591), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8600), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8607), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8615), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8542), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8584), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8592), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8601), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8608), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8616), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8576), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8585), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8593), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8602), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8609), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8617), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8568), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8577), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8586), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8594), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8603), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8618), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8625), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8578), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8587), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8595), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8603), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8611), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8619), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8571), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8579), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8588), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8596), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8604), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8612), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8627), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8629), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8635), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8631), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8636), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8713), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8736), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8745), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8632), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8737), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8633), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8638), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8733), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8737), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8742), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8634), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8717), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8729), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8734), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8738), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 12, 4, 10, 46, 3, 456, DateTimeKind.Local).AddTicks(8749) });
        }
    }
}
