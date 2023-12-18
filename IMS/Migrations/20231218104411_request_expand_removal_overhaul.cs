using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_expand_removal_overhaul : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemovalStatus",
                table: "RequestExpands");

            migrationBuilder.AddColumn<bool>(
                name: "ForRemoval",
                table: "RequestExpands",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForRemoval",
                table: "RequestExpands");

            migrationBuilder.AddColumn<int>(
                name: "RemovalStatus",
                table: "RequestExpands",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5517), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "6449de8c-b180-4f7f-84b5-14aaf04a5d52", new DateTime(2023, 12, 18, 17, 5, 32, 294, DateTimeKind.Local).AddTicks(698), new DateTime(2023, 12, 18, 17, 5, 32, 294, DateTimeKind.Local).AddTicks(713), new List<string>(), "AQAAAAIAAYagAAAAEHo+ElMvpONiCg5wykRlgVEb7v8eUkw87zIvx7gb63YXtM8oy7qmmtM56GLwCpUcag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c98446cd-d55e-4bcf-9b6c-17ba7bd57c83", new DateTime(2023, 12, 18, 17, 5, 32, 446, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 12, 18, 17, 5, 32, 446, DateTimeKind.Local).AddTicks(4632), new List<string>(), "AQAAAAIAAYagAAAAEGlutAzDeRDhyG4OsTsmcKXDyOQMKcQ54yGNNkl4tcu3hp+kdWA/kZTUvBo4l3/GZw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a4f9b431-7b0a-4881-b651-0b435b256a47", new DateTime(2023, 12, 18, 17, 5, 32, 188, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 12, 18, 17, 5, 32, 188, DateTimeKind.Local).AddTicks(8785), new List<string>(), "AQAAAAIAAYagAAAAELXWWztCnMISAw5J/4HEQnfltMqy/60H9uJ73TXlgruK9yvc4NLPgkC5P1e+6ZOZWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "78427bd5-2563-43a2-b770-c1e1147b5464", new DateTime(2023, 12, 18, 17, 5, 32, 107, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 12, 18, 17, 5, 32, 107, DateTimeKind.Local).AddTicks(4010), new List<string>(), "AQAAAAIAAYagAAAAELm54G1vzCOfzF8U9ntzKJPFCG3KnNdde34Z91/w6wbqMQXs1GYsfXRe3Z3nwi0bZA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5322), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5470), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5479), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5486), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5493), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5535), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5585), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5594), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5602), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5658), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5667), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5674), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5595), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5660), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5668), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5675), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5542), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5579), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5588), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5661), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5669), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5676), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5662), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5670), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5677), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5663), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5670), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5678), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5555), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5582), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5591), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5663), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5671), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5679), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5583), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5664), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5672), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5680), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5593), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5665), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5673), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5681), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5695), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5705), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5686), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5691), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5696), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5706), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5711), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5716), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5687), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5702), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5707), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5688), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5693), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5698), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5713), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5689), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5694), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5699), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5704), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5709), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5719), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5724) });
        }
    }
}
