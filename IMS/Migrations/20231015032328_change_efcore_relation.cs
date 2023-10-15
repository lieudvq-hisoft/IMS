using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_efcore_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Servers_DeviceId",
                table: "Servers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4558), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4942c0f5-b843-4960-990c-0bcb3e987468", "AQAAAAIAAYagAAAAEOx+lTzTleyIdADrrZfTDQWFX6VCQertWQVgqga3+4be78J1dAtxiKZHlr99eYlaLA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29ce73d6-13fd-4acb-9d9c-091731ca93b3", "AQAAAAIAAYagAAAAEIedclAbqb2iToAP5V4NvrzQK3Zf0pYoCX4LB3LyImYWSadV92yN/plKkBXUh3L1Ig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecea7c88-70ae-4560-80cc-c399320a87a0", "AQAAAAIAAYagAAAAEMWVE59l1pDig2IVrbpO3FTYza8cbPH6LdpQKv/VOcR8cC6dsqqxo2uE+HAcFbx1KQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa6d7270-3d5c-46a6-b16f-9d183f3d615a", "AQAAAAIAAYagAAAAEONZK8dYJYhmACpyDzo8PcoUf555BcCg474VcLuAwgH749zd30iA+NYke9BJqQssUw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(6), new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "DeviceLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6434), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4489), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6404), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4628), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4845), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5071), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5361), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5588), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5782), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4668), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4861), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5372), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5467), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5794), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4873), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5384), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5479), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5713), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5805), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4704), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4885), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5109), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5396), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5623), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5724), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4718), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5120), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5502), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5634), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5736), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5829), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4740), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4930), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5319), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5646), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5038), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5337), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5565), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5658), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5759), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5349), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5442), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5576), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5678), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5914), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6078), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6133), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6229), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5982), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6144), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6100), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6194), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6359), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5950), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6110), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6370), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5961), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6121), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6218), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6272), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6381), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(43), new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.CreateIndex(
                name: "IX_Servers_DeviceId",
                table: "Servers",
                column: "DeviceId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Servers_DeviceId",
                table: "Servers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3380), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3403), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59590666-d50b-4527-bd84-62fb3ae10b89", "AQAAAAIAAYagAAAAEDqYtDAGCfxreHa6rlRa/TkEWD5Yz/1a6J+3c8eUs6fiC7b/CppbsjjwVanlVP/ROg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "263cecb5-c852-47bd-a7bd-96f463bb876e", "AQAAAAIAAYagAAAAEKvmWGFxHBcBDBVKNtbtFXPj3l8pB84QXOm/mVWi6XLRfRVfwASP7GUEUyJBsaVczQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93967dc2-ee1d-489f-8053-b3096af6dc68", "AQAAAAIAAYagAAAAEN1DP5uWHmpBKf2oSIWsQesrQigubkSaPrDXnOdZFptqOgR7cthKmkVwzNmS22LBCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a3ea6eb-6109-4666-927e-f52540152394", "AQAAAAIAAYagAAAAEBom9dmr4guX+6jOdTgehm6bQ2lHx6yYZBxgb5oAPetyNAeJlkwb1O0BrXD1UjZFcA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3036), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "DeviceLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6425), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5411), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5595), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5673), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4977), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5422), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5759), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3477), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4993), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5433), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5768), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5444), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5626), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5777), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5038), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5635), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5787), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3616), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5048), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5141), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5464), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5645), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5911), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5059), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5573), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5731), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3640), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5395), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5663), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5740), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6001), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6139), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6187), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6235), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6282), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6332), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5953), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6196), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6292), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5962), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6158), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6038), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6117), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6312), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5981), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6129), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6178), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6224), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6272), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6402), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3150), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3166), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3174), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.CreateIndex(
                name: "IX_Servers_DeviceId",
                table: "Servers",
                column: "DeviceId");
        }
    }
}
