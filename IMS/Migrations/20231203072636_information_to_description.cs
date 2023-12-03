using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class information_to_description : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Information",
                table: "ServerHardwareConfigs",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Information",
                table: "RequestUpgrades",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9224), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9239), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "66ffae2e-e328-4601-a192-e62ca5f8c417", new DateTime(2023, 12, 3, 14, 26, 35, 297, DateTimeKind.Local).AddTicks(7611), new DateTime(2023, 12, 3, 14, 26, 35, 297, DateTimeKind.Local).AddTicks(7622), "AQAAAAIAAYagAAAAEK0e4POofg3E9TAJp0Ecz/J08nMV1U4HGV1eub/dqP7MPnOhPNYE55qOo4ackvAvQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3ce86f3d-9746-4e1a-a986-76186b5a01ad", new DateTime(2023, 12, 3, 14, 26, 35, 161, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 12, 3, 14, 26, 35, 161, DateTimeKind.Local).AddTicks(1573), "AQAAAAIAAYagAAAAEIm7Ta7vIDPrlSmaKt2BKuv+esPfIhO0wivREsLfEFdZKDMMz1CHjS/NINRC3Ae00g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ff6dc270-ac5a-493a-989d-2e6a93d5e22e", new DateTime(2023, 12, 3, 14, 26, 35, 229, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 12, 3, 14, 26, 35, 229, DateTimeKind.Local).AddTicks(3518), "AQAAAAIAAYagAAAAEAhQJfhWcHbvvVeXeyTQQVTEZDHjSzEHM8dN1pfYahPD+B2/+t09rIv4MbyOy0XBig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "896b93ae-91d5-42f2-be49-1f4ba774a626", new DateTime(2023, 12, 3, 14, 26, 35, 84, DateTimeKind.Local).AddTicks(5831), new DateTime(2023, 12, 3, 14, 26, 35, 84, DateTimeKind.Local).AddTicks(5843), "AQAAAAIAAYagAAAAEFCLlbyAM3SPF0KINT42lk6D2j0LI8E/tcJLI7dIlREyPRtSwdPwypl5gPtlN4OTKg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4612caf2-4a09-41dc-a552-e45d6f044fb0", new DateTime(2023, 12, 3, 14, 26, 35, 16, DateTimeKind.Local).AddTicks(7382), new DateTime(2023, 12, 3, 14, 26, 35, 16, DateTimeKind.Local).AddTicks(7393), "AQAAAAIAAYagAAAAENf/GHhgcqPPXlYxXbzOAJPwPzDYhXiskCvGmL2qUXOxcPmulIwA3uHEb6lWMDiSdw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9070), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9169), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9194), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9207), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9285), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9340), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9349), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9357), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9366), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9375), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9383), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9254), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9287), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9342), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9350), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9359), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9367), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9384), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9255), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9288), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9343), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9351), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9360), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9368), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9377), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9385), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9256), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9289), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9344), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9352), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9361), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9369), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9378), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9386), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9264), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9290), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9345), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9353), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9362), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9370), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9379), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9387), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9267), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9336), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9346), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9354), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9363), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9380), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9388), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9282), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9337), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9347), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9355), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9364), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9372), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9389), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9284), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9338), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9348), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9356), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9365), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9373), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9382), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9390), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9391), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9398), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9403), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9408), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9413), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9418), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9457), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9462), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9393), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9399), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9404), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9414), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9419), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9463), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9394), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9400), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9405), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9410), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9415), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9420), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9459), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9464), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9395), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9406), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9411), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9416), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9455), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9460), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9465), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9397), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9402), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9407), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9412), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9417), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9461), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9466), new DateTime(2023, 12, 3, 14, 26, 35, 11, DateTimeKind.Local).AddTicks(9467) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ServerHardwareConfigs",
                newName: "Information");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "RequestUpgrades",
                newName: "Information");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2875), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "042eec40-b6d6-44d5-b7e3-811ae2724f54", new DateTime(2023, 12, 3, 13, 6, 20, 900, DateTimeKind.Local).AddTicks(2676), new DateTime(2023, 12, 3, 13, 6, 20, 900, DateTimeKind.Local).AddTicks(2687), "AQAAAAIAAYagAAAAEOKped3KF0p7rnjFTlNzNGPjoVqKT/qdNJZ2ri1H6e/i89CTY9zlOLxwILWwusqpWA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "58046b51-f59f-4211-9f7e-db689ccc6299", new DateTime(2023, 12, 3, 13, 6, 20, 749, DateTimeKind.Local).AddTicks(1390), new DateTime(2023, 12, 3, 13, 6, 20, 749, DateTimeKind.Local).AddTicks(1401), "AQAAAAIAAYagAAAAEEFA0pHkc0EjQJixsxoPFgxiPX7Ygg/u6CPssESknRIsGaWgdgxf9kEH8dmhxKsmWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "75853a8d-2e6f-4050-a8a7-798b564983cf", new DateTime(2023, 12, 3, 13, 6, 20, 826, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 12, 3, 13, 6, 20, 826, DateTimeKind.Local).AddTicks(444), "AQAAAAIAAYagAAAAEImhhbhNH+TCaICwwVF5NeRavdaZTQVQTfgX8WpVhpiQyt3nc5qjfm27jotVMntEMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a51230db-8d55-4732-b6eb-340fcbc80989", new DateTime(2023, 12, 3, 13, 6, 20, 673, DateTimeKind.Local).AddTicks(6873), new DateTime(2023, 12, 3, 13, 6, 20, 673, DateTimeKind.Local).AddTicks(6883), "AQAAAAIAAYagAAAAEOqng77v/xkNfj3DRTNwfllg6YjT4olI1vpCVcbhuIsPpF9fqzA8SyPTe1e7NO9ZXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "29829425-8245-4cb4-9d18-b10abd3187dd", new DateTime(2023, 12, 3, 13, 6, 20, 602, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 12, 3, 13, 6, 20, 602, DateTimeKind.Local).AddTicks(5930), "AQAAAAIAAYagAAAAEFuwFFRH9L3RbOApN9cx10+8mbNunHKeNlxPY6n4ioyHLM3WpOoZvPWiRk8KczPppQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2829), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2914), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3006), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2885), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2999), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2918), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2982), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2975), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2894), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2976), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3019), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2897), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2921), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2985), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3003), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3020), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2986), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2995), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3004), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3012), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2987), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2996), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3005), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3036), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3041), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3046), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3051), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3056), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3031), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3042), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3027), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3033), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3053), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3058), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3034), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3044), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3049), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3093), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3099), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3029), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3040), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3045), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3055), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3100) });
        }
    }
}
