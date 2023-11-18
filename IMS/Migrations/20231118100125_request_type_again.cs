using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_type_again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequestType",
                table: "RequestUpgrades",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestType",
                table: "RequestHosts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestType",
                table: "RequestExpands",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3175), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3195), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a8ada35b-f626-4a73-a609-290345463416", new DateTime(2023, 11, 18, 17, 1, 24, 787, DateTimeKind.Local).AddTicks(260), new DateTime(2023, 11, 18, 17, 1, 24, 787, DateTimeKind.Local).AddTicks(272), "AQAAAAIAAYagAAAAEGis7KqOBCzcsi76rPS2I/h5YyZDQ+qnvOZ/D79evm7/kKXNxj/cOOMepN5NbaXWBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "36aac5e3-1f80-4f3f-8e3a-7a582536c30b", new DateTime(2023, 11, 18, 17, 1, 24, 628, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 11, 18, 17, 1, 24, 628, DateTimeKind.Local).AddTicks(2822), "AQAAAAIAAYagAAAAEEh2Nyq911MIf6sPGaFuNlXNdcJKb81mN2/gIwuVXRmOnQ+kPA1Bkt31gG8Xhfxebw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b391b07b-d93a-4e61-87cc-f9e017cc0aca", new DateTime(2023, 11, 18, 17, 1, 24, 718, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 11, 18, 17, 1, 24, 718, DateTimeKind.Local).AddTicks(4064), "AQAAAAIAAYagAAAAEE1hysSPPU23Xby9HA+oz1UfErxACDRpvQTL8A4FhtfwkjTvGuYOx9bvKsHrX03itQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8d122260-66d3-4f74-b52e-c16443394726", new DateTime(2023, 11, 18, 17, 1, 24, 558, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 11, 18, 17, 1, 24, 558, DateTimeKind.Local).AddTicks(6880), "AQAAAAIAAYagAAAAEDCGWewXixdOEJOBJ3rPOUtsI5qmZFyEjZvbgVVOwq4sTUuK4PzMPzK2kSlBpvo9/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9bdb81a7-a061-4e6e-a44e-c2d2ec1eaca6", new DateTime(2023, 11, 18, 17, 1, 24, 480, DateTimeKind.Local).AddTicks(2892), new DateTime(2023, 11, 18, 17, 1, 24, 480, DateTimeKind.Local).AddTicks(2903), "AQAAAAIAAYagAAAAEOxwzRwc0+pWpWSCHyiAkWszyDsw+jVNaCGPPDPFM//Y3n0rgHCoGgiJRIeeLFFWAw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3083), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3111), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3204), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3235), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3252), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3269), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3277), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3285), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3226), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3237), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3245), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3253), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3262), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3278), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3286), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3227), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3254), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3263), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3271), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3279), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3287), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3239), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3247), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3255), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3272), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3280), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3288), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3248), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3265), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3273), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3289), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3257), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3266), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3274), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3290), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3242), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3250), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3258), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3267), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3275), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3283), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3290), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3234), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3243), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3251), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3259), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3268), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3276), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3284), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3291), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3294), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3306), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3316), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3321), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3326), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3336), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3301), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3307), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3317), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3322), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3327), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3337), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3308), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3313), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3318), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3338), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3309), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3314), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3319), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3324), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3329), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3334), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3339), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3310), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3315), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3320), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3330), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3335), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3340), new DateTime(2023, 11, 18, 17, 1, 24, 475, DateTimeKind.Local).AddTicks(3340) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestType",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "RequestType",
                table: "RequestHosts");

            migrationBuilder.DropColumn(
                name: "RequestType",
                table: "RequestExpands");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4633), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6df4e5ec-2dfd-42f7-b93e-9fdf182991f0", new DateTime(2023, 11, 18, 16, 57, 30, 950, DateTimeKind.Local).AddTicks(9201), new DateTime(2023, 11, 18, 16, 57, 30, 950, DateTimeKind.Local).AddTicks(9214), "AQAAAAIAAYagAAAAEOtS0TbcSEGnmMcCJi/9jiea49R8AdFLYLgkQMrHHG+cvm5VcE7y0OP52sjwxQOdtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "30fe9c37-b4c1-4c34-aa79-267e3eb325db", new DateTime(2023, 11, 18, 16, 57, 30, 807, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 11, 18, 16, 57, 30, 807, DateTimeKind.Local).AddTicks(1588), "AQAAAAIAAYagAAAAELRiYA12ikq0CcvJWLsViGdsgK7qOLPFwu9tIPJ+SKmuLPPFuXBSUw6MP2s4HkvEAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "117cb553-5f14-4e3c-9dc0-22ead36983a0", new DateTime(2023, 11, 18, 16, 57, 30, 881, DateTimeKind.Local).AddTicks(9581), new DateTime(2023, 11, 18, 16, 57, 30, 881, DateTimeKind.Local).AddTicks(9591), "AQAAAAIAAYagAAAAEE7uF7DMBnC2nA+QSSsAyGEHBM1QP3FI7yF8zUJxOhQP4aeCmJmk/QjvM7ocJXQQOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "686a92c4-b24a-47e5-87c9-8d2a313ab29d", new DateTime(2023, 11, 18, 16, 57, 30, 729, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 11, 18, 16, 57, 30, 729, DateTimeKind.Local).AddTicks(2872), "AQAAAAIAAYagAAAAEIUs/R5q1Je4kDLTSD462yAMQ24GVqCWmnO0WSG8yI1HfBETZQoJgyCBE7RyTcDMKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "79cd7e09-5a8b-4538-9363-991acb6932b5", new DateTime(2023, 11, 18, 16, 57, 30, 654, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 11, 18, 16, 57, 30, 654, DateTimeKind.Local).AddTicks(3207), "AQAAAAIAAYagAAAAED1qfV3hVPOHlNkgi72+JDRKypUSH3vF/kf3A/pdJq0Kwez17GqhBlnNi63qUC3+wg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4334), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4418), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4444), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4535), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4577), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4592), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4564), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4651), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4677), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4686), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4695), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4703), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4711), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4719), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4726), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4656), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4679), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4688), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4696), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4704), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4712), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4689), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4697), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4713), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4789), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4681), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4698), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4706), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4714), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4721), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4672), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4682), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4691), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4699), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4707), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4715), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4722), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4791), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4683), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4692), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4699), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4708), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4792), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4675), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4693), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4709), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4717), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4724), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4793), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4694), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4702), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4718), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4725), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4794), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4802), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4808), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4813), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4823), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4798), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4809), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4824), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4833), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4799), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4805), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4834), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4800), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4811), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4815), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4820), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4826), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4801), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4807), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4811), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4837) });
        }
    }
}
