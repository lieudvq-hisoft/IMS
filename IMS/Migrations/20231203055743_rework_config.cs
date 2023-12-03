using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class rework_config : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "ServerHardwareConfigs");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Components");

            migrationBuilder.AddColumn<bool>(
                name: "IsRequired",
                table: "Components",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2406), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2423), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "94105722-4b5f-4f5c-97b3-1498cd93e6d2", new DateTime(2023, 12, 3, 12, 57, 42, 171, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 12, 3, 12, 57, 42, 171, DateTimeKind.Local).AddTicks(9976), "AQAAAAIAAYagAAAAEEJzhY+zwub1O7HKf2s662KBwq2Lc83E/cEtQAfmy80bJ04vPp3IxfXuIcy1fWvW2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1bac9832-ebe4-4ee2-947b-a8c1572aef62", new DateTime(2023, 12, 3, 12, 57, 42, 19, DateTimeKind.Local).AddTicks(8092), new DateTime(2023, 12, 3, 12, 57, 42, 19, DateTimeKind.Local).AddTicks(8103), "AQAAAAIAAYagAAAAEOg3IYz+OdI166zIWIODRxyI3DmLgu0SD1qcW6xPsJ1vouFsu/D8PfccD/rq2lgiDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "51a4c184-47c3-4cca-aa3a-f9ba9e919c74", new DateTime(2023, 12, 3, 12, 57, 42, 97, DateTimeKind.Local).AddTicks(7848), new DateTime(2023, 12, 3, 12, 57, 42, 97, DateTimeKind.Local).AddTicks(7858), "AQAAAAIAAYagAAAAEDo3+ObPE6uPTsz8T31uJqOFXSbSE6lB0eDg06fnebMGGlFkH/oVqgcqHL2YD7O5Og==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9d4b2ab8-6741-41f2-883c-e7d0c83e9643", new DateTime(2023, 12, 3, 12, 57, 41, 949, DateTimeKind.Local).AddTicks(197), new DateTime(2023, 12, 3, 12, 57, 41, 949, DateTimeKind.Local).AddTicks(207), "AQAAAAIAAYagAAAAEHo9+rlGjCVVhZXCPjMj8VgytJJdUuunzgsIforStGAGJiUnoEnvdyf2Xfp6IqmP3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e7c72fe3-5eb5-4d46-ae3a-01554cb0f205", new DateTime(2023, 12, 3, 12, 57, 41, 880, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 12, 3, 12, 57, 41, 880, DateTimeKind.Local).AddTicks(2396), "AQAAAAIAAYagAAAAEHWVqGruPOVSgDxfHsm5sYbA1p0zAlvc4bUBaVT6xja4/7jz4tbbPGNUMkRVAw6rwg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2176), true });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2326), true });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2341), true });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2354), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2354), false });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired", "Name" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2368), true, "Motherboard" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired", "Name" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2383), true, "Harddisk" });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2428), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2473), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2482), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2499), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2508), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2517), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2525), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2484), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2501), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2518), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2526), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2443), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2486), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2493), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2502), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2519), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2477), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2494), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2503), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2528), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2495), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2504), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2513), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2529), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2470), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2479), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2496), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2505), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2513), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2521), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2530), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2489), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2497), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2515), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2522), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2481), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2490), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2498), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2507), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2524), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2533), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2558), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2579), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2538), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2543), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2576), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2581), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2582) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRequired",
                table: "Components");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "ServerHardwareConfigs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "RequestUpgrades",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Components",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Components",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(167), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(183), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "61815159-1bd2-4ae2-8108-768bafffa4db", new DateTime(2023, 12, 3, 0, 6, 40, 331, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 12, 3, 0, 6, 40, 331, DateTimeKind.Local).AddTicks(2802), "AQAAAAIAAYagAAAAEGrIbYRGoW5cajB3iKYT3ICP6CT+yvgVOLx4lTabLg3ShVTxNQ7nxYsGPijQjlDZGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "112a994a-dd46-423e-a366-c4b75ea724f7", new DateTime(2023, 12, 3, 0, 6, 39, 982, DateTimeKind.Local).AddTicks(1095), new DateTime(2023, 12, 3, 0, 6, 39, 982, DateTimeKind.Local).AddTicks(1112), "AQAAAAIAAYagAAAAEI/esZ+Uy1G68Cuq4DhfuoeQQZrpgM+pnm/ICEMKWM9xKD8QKGBnEvu2mgss822dBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6f0bc564-0684-44d8-9cef-ed5c98b174b1", new DateTime(2023, 12, 3, 0, 6, 40, 126, DateTimeKind.Local).AddTicks(942), new DateTime(2023, 12, 3, 0, 6, 40, 126, DateTimeKind.Local).AddTicks(954), "AQAAAAIAAYagAAAAEIX47AjEK7Uu/m1htgxW4FrFstipye0jgFW+7OcoUOPflHPp5ctGgwEJdcgPi6DzXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "fca3c1a4-0bfb-460d-bee2-736103bfbf48", new DateTime(2023, 12, 3, 0, 6, 39, 896, DateTimeKind.Local).AddTicks(3504), new DateTime(2023, 12, 3, 0, 6, 39, 896, DateTimeKind.Local).AddTicks(3522), "AQAAAAIAAYagAAAAECZfAXdhfSizyvQLtwmbOYpxGwM8qZWX42SXWDi4KZY1qfyn1C1avo85r4ryJwK/Yw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "fde2dc7e-56c6-4976-bd48-ebd666fed147", new DateTime(2023, 12, 3, 0, 6, 39, 792, DateTimeKind.Local).AddTicks(7062), new DateTime(2023, 12, 3, 0, 6, 39, 792, DateTimeKind.Local).AddTicks(7079), "AQAAAAIAAYagAAAAEAVfLHlaOLrKLPSu1i4RPQuhhkRNvajJPfDshqCqSmmNP2Db34RiUCHosOPSRhXGWA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Type", "Unit" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 782, DateTimeKind.Local).AddTicks(9882), new DateTime(2023, 12, 3, 0, 6, 39, 782, DateTimeKind.Local).AddTicks(9894), 1, "Cái" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Type", "Unit" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(37), 1, "Cái" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Type", "Unit" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(51), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(52), 1, "Cái" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Type", "Unit" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(129), 1, "Cái" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "Name", "Type", "Unit" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(141), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(141), "ROM", 1, "Cái" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "Name", "Type", "Unit" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(116), "RAM", 0, "Cái" });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(220), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(266), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(275), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(318), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(233), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(286), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(295), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(303), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(235), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(269), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(278), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(296), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(312), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(236), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(270), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(288), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(297), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(321), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(246), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(271), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(280), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(289), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(298), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(306), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(314), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(248), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(272), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(281), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(307), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(315), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(264), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(300), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(308), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(283), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(292), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(325), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(327), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(375), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(380), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(385), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(390), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(396), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(406), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(376), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(386), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(392), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(397), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(402), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(407), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(372), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(377), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(382), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(403), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(408), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(388), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(394), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(374), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(379), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(395), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(400), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(410) });
        }
    }
}
