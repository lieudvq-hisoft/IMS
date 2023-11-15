using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class sale_tech_note_server_allocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InspectorNote",
                table: "ServerAllocations",
                newName: "TechNote");

            migrationBuilder.AddColumn<string>(
                name: "SaleNote",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5979), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c328e953-3fe6-4bff-9ccb-1273856e8233", new DateTime(2023, 11, 15, 15, 3, 28, 78, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 11, 15, 15, 3, 28, 78, DateTimeKind.Local).AddTicks(6578), "AQAAAAIAAYagAAAAENitAt/Xff47ccV03ix2sLxCf/aSLMQtCkacgbnyRYCG0Hxhe3SePiL/5RnX+C52KA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "d503eda9-1f22-40dd-8c53-b557ed99c384", new DateTime(2023, 11, 15, 15, 3, 27, 919, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 11, 15, 15, 3, 27, 919, DateTimeKind.Local).AddTicks(2883), "AQAAAAIAAYagAAAAED62ye3UdxC0MtRcMkyF6/ViHL6WnsiAErSFqZ325y8khYyL8IDTreN2Z8uGNjkYfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a4a81137-3a92-4370-acd8-9acec4ee2396", new DateTime(2023, 11, 15, 15, 3, 27, 993, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 11, 15, 15, 3, 27, 993, DateTimeKind.Local).AddTicks(1688), "AQAAAAIAAYagAAAAELkuudSarVBo6o7ytWHVAdYkhJNBX8beW3/FrCsKWt+kzQXeJkQ/pAX8oLRwuH5fgw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1c8ab246-4000-4a50-82f6-f210ec96b9b9", new DateTime(2023, 11, 15, 15, 3, 27, 851, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 11, 15, 15, 3, 27, 851, DateTimeKind.Local).AddTicks(3273), "AQAAAAIAAYagAAAAEJAA5UhBmQWSvuwrClTn8lqvbXh9hdRyi36uSNxwWcyajWB1HxsMy9hY99liTfQksA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "670c94b3-cdae-4649-ad92-69b736af6434", new DateTime(2023, 11, 15, 15, 3, 27, 782, DateTimeKind.Local).AddTicks(9870), new DateTime(2023, 11, 15, 15, 3, 27, 782, DateTimeKind.Local).AddTicks(9881), "AQAAAAIAAYagAAAAEIJdni8hxOWusFhEF8tNEOTLO+WW5OTlHB1UVvRFUolnmyl23Gd4yy94l+VZi7gsfA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5739), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5831), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5864), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5947), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5984), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6013), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6024), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6032), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6058), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6005), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6016), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6051), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6026), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6052), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6007), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6027), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6035), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6045), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6061), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6054), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6077), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6078), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6064), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6079), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6080), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6087), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6092), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6098), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6102), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6107), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6112), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6117), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6083), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6088), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6093), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6098), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6108), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6113), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6118), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6084), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6099), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6104), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6109), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6114), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6119), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6085), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6090), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6095), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6100), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6105), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6110), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6115), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6120), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6086), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6091), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6096), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6101), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6106), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6116), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6121), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6121) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleNote",
                table: "ServerAllocations");

            migrationBuilder.RenameColumn(
                name: "TechNote",
                table: "ServerAllocations",
                newName: "InspectorNote");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "becdee10-545c-4132-8153-c3080245a0d9", new DateTime(2023, 11, 15, 14, 21, 57, 859, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 11, 15, 14, 21, 57, 859, DateTimeKind.Local).AddTicks(5847), "AQAAAAIAAYagAAAAEBgnvZ4+lZGffDserNu1jGizozBFBEUeGzKnRLY/fmrEy0sBPycGp9a+GJDjffNbbA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6da09bc7-dedd-401c-bce8-1d9d26cfe577", new DateTime(2023, 11, 15, 14, 21, 57, 651, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 11, 15, 14, 21, 57, 651, DateTimeKind.Local).AddTicks(5053), "AQAAAAIAAYagAAAAEIEKn4sXd/fJ3u80Fth0y63gl9rzb6B5qB3OFcFhmwO0AuKl2qR4piH+2XnJ2p9Tyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "58230546-3d7a-4cda-97f7-fea9958e644c", new DateTime(2023, 11, 15, 14, 21, 57, 760, DateTimeKind.Local).AddTicks(5632), new DateTime(2023, 11, 15, 14, 21, 57, 760, DateTimeKind.Local).AddTicks(5643), "AQAAAAIAAYagAAAAEFTePy7TnJeU+zx8MQTSQ02MLI1n0AecZaQqUwo44dE3TwxjH52iy0HU4BwM4i958w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3987bd22-9d63-4f4d-81d1-0ccd23200846", new DateTime(2023, 11, 15, 14, 21, 57, 553, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 11, 15, 14, 21, 57, 553, DateTimeKind.Local).AddTicks(6319), "AQAAAAIAAYagAAAAEKez0Rrhj3gQifzfgUAOTfezRTOC2NsDLq9NS5622mpm//6U+sLfjDnbHbTe7i2JNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "165b4a62-f0ef-4ef9-938c-1a5d6ceb2a72", new DateTime(2023, 11, 15, 14, 21, 57, 464, DateTimeKind.Local).AddTicks(4057), new DateTime(2023, 11, 15, 14, 21, 57, 464, DateTimeKind.Local).AddTicks(4064), "AQAAAAIAAYagAAAAENVuDYr9qfWFta1Lg6oGyTtzfWTNObBASUHphb84D1+SBrTv1RvWeKDScUGLCK945w==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3605), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3725), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3737), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3750), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3772), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3800), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3829), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3868), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3842), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3914), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3984), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4003), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4012), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4022), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4030), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4038), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3919), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3986), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3996), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4014), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4023), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4031), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4039), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3975), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4005), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4015), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4040), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3988), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3998), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4006), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4016), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4025), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4041), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3978), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3989), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3999), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4007), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4017), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4034), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4042), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4000), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4009), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4018), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4027), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4035), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4043), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4001), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4010), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4019), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4036), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4044), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3993), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4002), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4021), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4029), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4045), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4047), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4094), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4104), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4108), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4113), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4119), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4105), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4109), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4114), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4120), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4050), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4106), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4110), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4115), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4121), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4091), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4096), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4102), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4106), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4111), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4117), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4121), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4052), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4092), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4097), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4102), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4107), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4112), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4117), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4122), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4123) });
        }
    }
}
