using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class max_power_to_int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPower",
                table: "Racks");

            migrationBuilder.AlterColumn<int>(
                name: "MaxPower",
                table: "Racks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9f26d64c-7082-4a5f-b96d-b4a20c1438f8", new DateTime(2023, 11, 16, 11, 50, 25, 481, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 11, 16, 11, 50, 25, 481, DateTimeKind.Local).AddTicks(1685), "AQAAAAIAAYagAAAAEAH8CrMFEtxM+hKbH2zhbibWhn1zkq69ZncbhAp/cALJVXi+PM7uLnxciZekU1YtiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6e4c1fc2-3e73-4e1e-afea-8b36cff3cbf5", new DateTime(2023, 11, 16, 11, 50, 25, 303, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 11, 16, 11, 50, 25, 303, DateTimeKind.Local).AddTicks(7398), "AQAAAAIAAYagAAAAEHOacW2LPRtTV6EfH6erB9nr5DUKVPeU/EgBz9S19i4J3nfaQY2XsB94tn1TIH2V9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a653a553-a072-4874-b744-ac92ea18cdb1", new DateTime(2023, 11, 16, 11, 50, 25, 395, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 11, 16, 11, 50, 25, 395, DateTimeKind.Local).AddTicks(9991), "AQAAAAIAAYagAAAAEHn2FKNLKj1KKxaDkKPA9DAHf6GjbSxoCHh6U6cgoMQ3sH4c93MD383r5O5FSEMZdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4ec99588-dc6f-4c60-a2d4-66e02e948f84", new DateTime(2023, 11, 16, 11, 50, 25, 219, DateTimeKind.Local).AddTicks(9364), new DateTime(2023, 11, 16, 11, 50, 25, 219, DateTimeKind.Local).AddTicks(9380), "AQAAAAIAAYagAAAAEH2TItraHFkkA6LowIWd77x8Afij9j2XxKU9jAIlzNALQhc/IsRBdBqigKXtLFJ0aQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e53142d0-3d2f-4fda-a0e6-49bbc87ae060", new DateTime(2023, 11, 16, 11, 50, 25, 148, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 11, 16, 11, 50, 25, 148, DateTimeKind.Local).AddTicks(8988), "AQAAAAIAAYagAAAAECEh3KXcgX1d3U79SukYUPHpdj6e5GOK5El9TtnU3NV5zp5N480eREIQCjhuQjjZZA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7948), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8001), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8060), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8061), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8101), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8101), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8110), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8110), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8118), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8119), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8126), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8135), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8142), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8142), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8150), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8150), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8065), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8069), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8103), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8111), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8112), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8119), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8120), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8128), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8128), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8135), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8136), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8143), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8143), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8150), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8151), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8093), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8104), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8104), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8113), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8120), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8121), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8129), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8129), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8137), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8144), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8151), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8152), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8094), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8094), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8105), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8105), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8113), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8114), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8122), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8130), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8130), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8138), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8145), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8152), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8153), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8095), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8096), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8106), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8106), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8114), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8115), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8122), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8122), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8131), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8131), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8139), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8146), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8146), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8153), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8154), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8098), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8107), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8115), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8116), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8123), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8123), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8132), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8132), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8139), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8140), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8147), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8147), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8154), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8155), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8099), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8099), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8108), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8108), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8116), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8117), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8124), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8124), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8132), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8133), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8140), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8148), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8148), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8155), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8156), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8100), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8109), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8109), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8117), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8118), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8125), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8133), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8134), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8141), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8141), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8149), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8149), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8157), 3000 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8158), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8158), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8170), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8171), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8175), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8175), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8180), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8181), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8185), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8185), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8190), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8195), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8195), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8200), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8160), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8160), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8171), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8172), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8176), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8176), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8181), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8181), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8186), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8186), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8191), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8191), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8196), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8196), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8201), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8201), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8161), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8161), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8172), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8173), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8177), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8177), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8182), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8183), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8187), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8187), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8192), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8192), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8197), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8202), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8202), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8168), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8173), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8173), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8178), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8179), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8183), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8183), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8188), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8188), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8193), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8193), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8198), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8198), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8203), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8203), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8169), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8169), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8174), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8174), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8179), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8179), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8184), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8184), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8189), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8189), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8194), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8194), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8199), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8199), 3500 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8204), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8204), 3500 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MaxPower",
                table: "Racks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<double>(
                name: "CurrentPower",
                table: "Racks",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5960), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1305642e-9428-41a6-8386-23c47f1580cb", new DateTime(2023, 11, 16, 0, 53, 53, 397, DateTimeKind.Local).AddTicks(6766), new DateTime(2023, 11, 16, 0, 53, 53, 397, DateTimeKind.Local).AddTicks(6780), "AQAAAAIAAYagAAAAEOoe+Wybl46lXgDtefRIQ4B4sLbNWvnxNHU4GHmyVo3uVx5GoxRsVlqLaa4xLRoygA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9946902d-ab54-49b9-968d-9ebac4aca7e8", new DateTime(2023, 11, 16, 0, 53, 53, 82, DateTimeKind.Local).AddTicks(1404), new DateTime(2023, 11, 16, 0, 53, 53, 82, DateTimeKind.Local).AddTicks(1414), "AQAAAAIAAYagAAAAEA1GC4tc1zl381yZdMPzP+O1mv/aAMtPHVJ03WpaHKWoDOXBxGHBm4/sGje32bOjPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "773ae69f-fe34-45e9-bb93-1f86703f4d09", new DateTime(2023, 11, 16, 0, 53, 53, 192, DateTimeKind.Local).AddTicks(4538), new DateTime(2023, 11, 16, 0, 53, 53, 192, DateTimeKind.Local).AddTicks(4550), "AQAAAAIAAYagAAAAEHCrb+UycsjqzPHNUCEn1RJ2nfIzGl5jARJtyvkiXz5VOP7Ph+bLZrpZDOVLPY4kPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3281b1e7-5462-4da4-a08e-0cad2583bf63", new DateTime(2023, 11, 16, 0, 53, 53, 5, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 11, 16, 0, 53, 53, 5, DateTimeKind.Local).AddTicks(6105), "AQAAAAIAAYagAAAAEPCJf5Ksoe4bn2xWBTpNikdGwEZcFMM8l2LQzZKlGHPijSoE8v0mMDdg+3MW3zf/JA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9f3f10af-372a-47db-8d9f-9591601abf9c", new DateTime(2023, 11, 16, 0, 53, 52, 900, DateTimeKind.Local).AddTicks(4487), new DateTime(2023, 11, 16, 0, 53, 52, 900, DateTimeKind.Local).AddTicks(4495), "AQAAAAIAAYagAAAAEN72NCU+BKJsKxR+lLWmyayF1hta9jxqz3s1vHNK3mSUDa8phbLubmI3IA2QBRPGdA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5786), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5801), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5813), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5826), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5846), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5903), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 200.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5966), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5969), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5996), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5996), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6005), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6005), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6015), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6023), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6038), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6038), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6046), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6054), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6055), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5986), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5987), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5998), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5998), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6007), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6007), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6016), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6024), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6025), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6039), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6047), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6056), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5988), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5988), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5999), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5999), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6008), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6008), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6017), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6026), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6040), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6048), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6057), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5989), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5989), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6000), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6000), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6009), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6018), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6032), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6033), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6041), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6049), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6058), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5990), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5991), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6001), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6001), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6010), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6010), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6019), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6034), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6042), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6050), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6058), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6059), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5993), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6002), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6002), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6012), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6020), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6035), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6035), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6043), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6051), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6052), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6059), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6060), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5994), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5994), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6003), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6013), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6021), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6036), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6044), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6052), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6053), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6061), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5995), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(5995), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6004), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6004), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6013), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6014), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6022), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6037), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6045), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6045), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6054), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6061), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6062), 3000.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6063), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6070), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6070), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6075), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6080), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6080), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6085), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6085), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6090), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6090), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6095), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6095), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6100), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6100), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6065), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6065), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6071), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6071), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6076), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6081), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6081), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6086), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6086), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6091), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6091), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6096), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6096), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6101), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6101), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6067), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6072), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6072), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6077), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6077), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6082), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6082), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6087), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6087), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6092), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6092), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6097), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6097), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6102), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6102), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6068), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6073), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6073), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6078), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6078), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6083), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6083), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6088), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6088), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6093), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6093), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6098), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6098), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6103), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6069), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6074), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6079), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6079), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6084), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6084), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6089), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6094), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6099), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6099), 3500.0 });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CurrentPower", "DateCreated", "DateUpdated", "MaxPower" },
                values: new object[] { 0.0, new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6104), new DateTime(2023, 11, 16, 0, 53, 52, 895, DateTimeKind.Local).AddTicks(6104), 3500.0 });
        }
    }
}
