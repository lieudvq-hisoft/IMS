using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class receiptOfRecipient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpectedSize",
                table: "ServerAllocations");

            migrationBuilder.DropColumn(
                name: "InspectionRecordFilePath",
                table: "ServerAllocations");

            migrationBuilder.DropColumn(
                name: "ReceiptOfRecipientFilePath",
                table: "ServerAllocations");

            migrationBuilder.AddColumn<string>(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestUpgrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestExpands",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2427), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2442), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c5623078-64e1-4c69-891a-d77c1f84400c", new DateTime(2023, 11, 20, 12, 21, 32, 732, DateTimeKind.Local).AddTicks(7178), new DateTime(2023, 11, 20, 12, 21, 32, 732, DateTimeKind.Local).AddTicks(7193), "AQAAAAIAAYagAAAAECb/G2yW50zs/bpgVVXUpaWwQXVjQhG+5vvq7pc3a1smFXEhyK2zlcDUrQfMR2Ygyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "795f8cb8-c483-4d3f-a228-94d8134285f6", new DateTime(2023, 11, 20, 12, 21, 32, 430, DateTimeKind.Local).AddTicks(6607), new DateTime(2023, 11, 20, 12, 21, 32, 430, DateTimeKind.Local).AddTicks(6619), "AQAAAAIAAYagAAAAEJG2BkfYnt/P67L3SV2jJARxfaKC9m2rlO8q78DFoNG4Rne1QpmGENraYFnZGYq/ew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "421a97f8-2ab9-4169-a395-01aa0deb4a20", new DateTime(2023, 11, 20, 12, 21, 32, 564, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 11, 20, 12, 21, 32, 564, DateTimeKind.Local).AddTicks(9185), "AQAAAAIAAYagAAAAEBRw0b0Y9C8OlWcBYbbgXxZq6RbRoO4X4Or+ytZNkhCLS6r8H7sAfgs36seczkBvEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3c0c362e-90a2-449e-aa12-60297422f9b6", new DateTime(2023, 11, 20, 12, 21, 32, 327, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 11, 20, 12, 21, 32, 327, DateTimeKind.Local).AddTicks(6427), "AQAAAAIAAYagAAAAEIxhvFzNNNbyFKUhO47jHXaUcVNf0ypteGxs7R8/+l0z6u9e7vM03SVVGgaVj7hf1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "31b265e4-a208-4d86-a588-0db5d4afd38e", new DateTime(2023, 11, 20, 12, 21, 32, 221, DateTimeKind.Local).AddTicks(7577), new DateTime(2023, 11, 20, 12, 21, 32, 221, DateTimeKind.Local).AddTicks(7598), "AQAAAAIAAYagAAAAEEaaDHNqzW9p03C2yLBq25p2W2dQ0MTMWtXJ9v/kMxMikJqM4dU8HrFiOFni+vXafQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2244), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2333), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2381), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2396), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2358), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2669), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2709), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2644), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2656), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2685), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2699), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2645), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2658), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2672), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2543), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2647), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2689), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2702), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2714), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2661), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2716), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2650), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2662), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2677), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2692), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2717), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2679), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2721), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2748), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2765), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2773), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2766), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2751), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2759), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2737), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2747), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2841) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestExpands");

            migrationBuilder.AddColumn<int>(
                name: "ExpectedSize",
                table: "ServerAllocations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InspectionRecordFilePath",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptOfRecipientFilePath",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3239), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "14d5aef3-4e78-4de6-9a63-94193c5a4e97", new DateTime(2023, 11, 18, 20, 11, 59, 420, DateTimeKind.Local).AddTicks(4894), new DateTime(2023, 11, 18, 20, 11, 59, 420, DateTimeKind.Local).AddTicks(4928), "AQAAAAIAAYagAAAAEAHDiucYp/NQniygtiqsVvUqorr87Js5UqZkToqesF+jE98HNRSRgTioAnhhHHdRoQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "76394aa1-9288-40a1-b6d1-9d145b8b0aca", new DateTime(2023, 11, 18, 20, 11, 59, 273, DateTimeKind.Local).AddTicks(3963), new DateTime(2023, 11, 18, 20, 11, 59, 273, DateTimeKind.Local).AddTicks(3975), "AQAAAAIAAYagAAAAELGYN0dQGOaZedEbAeE+523UJl82D/kNgQEvRf+uAs1apJcvtzbgpK/jGAZxuS8ePw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "818e2653-57e1-4bfc-8907-bd4a213e7295", new DateTime(2023, 11, 18, 20, 11, 59, 343, DateTimeKind.Local).AddTicks(611), new DateTime(2023, 11, 18, 20, 11, 59, 343, DateTimeKind.Local).AddTicks(622), "AQAAAAIAAYagAAAAEOYuRkZ3P4SWWN91l2oMsWh57B0qXTyN14n52FcwTTqsgsi7t6GZhJuye85gsqZQmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b043db9f-855f-4041-a198-7aeab3ca3234", new DateTime(2023, 11, 18, 20, 11, 59, 198, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 11, 18, 20, 11, 59, 198, DateTimeKind.Local).AddTicks(8807), "AQAAAAIAAYagAAAAEMNNXYUkZKkFgXYyjPzI2ej+9zewvazawmg/355H2gVQg1F8UHM8DAGgThP2JDelkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6a0d95c9-d857-4429-907c-4b033927cec8", new DateTime(2023, 11, 18, 20, 11, 59, 126, DateTimeKind.Local).AddTicks(6955), new DateTime(2023, 11, 18, 20, 11, 59, 126, DateTimeKind.Local).AddTicks(6971), "AQAAAAIAAYagAAAAEF/dofhQCdAvpc2mtY3k+sF31JaBsJnr8ybMOPWks9iZurcwvrRFXQ1bBg+vq4OFhQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2102), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2925), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2945), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3051), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3087), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3075), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3338), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3421), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3439), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3659), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3667), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3422), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3431), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3440), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3448), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3455), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3660), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3668), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3441), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3661), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3415), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3434), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3457), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3662), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3670), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3416), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3451), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3654), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3671), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3418), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3426), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3656), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3664), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3671), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3427), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3444), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3657), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3665), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3673), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3428), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3438), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3453), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3658), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3666), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3674), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3676), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3682), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3687), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3697), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3702), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3707), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3712), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3678), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3688), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3693), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3698), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3703), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3713), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3679), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3684), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3689), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3694), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3699), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3704), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3709), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3680), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3685), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3690), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3695), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3700), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3705), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3710), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3715), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3681), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3686), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3691), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3696), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3701), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3706), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3711), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3716), new DateTime(2023, 11, 18, 20, 11, 59, 122, DateTimeKind.Local).AddTicks(3716) });
        }
    }
}
