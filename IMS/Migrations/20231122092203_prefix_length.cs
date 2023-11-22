using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class prefix_length : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubnetMask",
                table: "IpSubnets",
                newName: "PrefixLength");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3122), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3138), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "037af667-46ca-421f-8e85-dc9993f4c18b", new DateTime(2023, 11, 22, 16, 22, 2, 555, DateTimeKind.Local).AddTicks(2215), new DateTime(2023, 11, 22, 16, 22, 2, 555, DateTimeKind.Local).AddTicks(2227), "AQAAAAIAAYagAAAAEPHqLnUFGs6692TyPaFK/QeoeXAquieZ/5iP/ygwNHKowNMwUPomvJ0wiuCtXtH2NQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f5e653cc-1ebc-48d8-9b6e-e082ecc476c5", new DateTime(2023, 11, 22, 16, 22, 2, 394, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 11, 22, 16, 22, 2, 394, DateTimeKind.Local).AddTicks(3591), "AQAAAAIAAYagAAAAEJy+PC6LWm2O4wM44qBiX8LgUd8/3t3LeSGKH+OxKvSg604GfxTAwXryWNvVIDMq7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6c322e43-ec05-48ac-aeee-cedb258a7abd", new DateTime(2023, 11, 22, 16, 22, 2, 468, DateTimeKind.Local).AddTicks(7195), new DateTime(2023, 11, 22, 16, 22, 2, 468, DateTimeKind.Local).AddTicks(7210), "AQAAAAIAAYagAAAAEJRivX/byHyRBlQoltwN0Zz+EDeT2OYEosmuk2cI0d2CRSOTwHAmpeR3YmyqVppLOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e062629e-84d1-421f-a645-adb0fc43daa3", new DateTime(2023, 11, 22, 16, 22, 2, 316, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 11, 22, 16, 22, 2, 316, DateTimeKind.Local).AddTicks(8992), "AQAAAAIAAYagAAAAENWdwpDKj19+8ZxnvEyffbm1/Aahin3yu4SVlZqRtdBcS2/dYq3wHCtM4JquB1eEIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b20745bf-3d41-48f0-8efe-ab8b0ed607fc", new DateTime(2023, 11, 22, 16, 22, 2, 247, DateTimeKind.Local).AddTicks(5495), new DateTime(2023, 11, 22, 16, 22, 2, 247, DateTimeKind.Local).AddTicks(5505), "AQAAAAIAAYagAAAAEBxvPJXg6Q7R8Ci238KDFEO8neKQ+addw45rtiGhVlLf2ALMc2OXgfDWaywq8W0AwA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3019), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3081), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3062), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3160), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3181), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3206), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3215), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3165), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3183), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3192), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3208), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3223), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3231), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3174), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3184), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3193), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3201), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3209), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3224), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3175), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3225), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3176), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3195), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3211), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3219), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3226), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3234), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3178), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3204), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3212), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3219), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3227), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3234), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3179), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3188), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3204), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3213), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3235), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3180), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3198), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3205), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3213), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3221), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3236), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3259), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3269), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3274), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3279), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3245), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3250), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3265), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3275), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3280), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3251), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3261), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3266), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3271), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3276), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3242), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3247), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3252), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3262), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3267), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3272), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3277), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3243), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3248), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3258), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3263), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3268), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3273), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3278), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3283) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrefixLength",
                table: "IpSubnets",
                newName: "SubnetMask");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "89e94238-137f-438b-bc25-320ec6b9d6e1", new DateTime(2023, 11, 22, 10, 47, 20, 56, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 11, 22, 10, 47, 20, 56, DateTimeKind.Local).AddTicks(6285), "AQAAAAIAAYagAAAAEJ1vLoyKNj5wenVlRIAUXUW8BNSe1xJfxRO8L7RIQBSxExaNWvKevvNgowmpmU/8Xg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4e153400-5021-405a-a013-f6e640c8c8e2", new DateTime(2023, 11, 22, 10, 47, 19, 877, DateTimeKind.Local).AddTicks(1900), new DateTime(2023, 11, 22, 10, 47, 19, 877, DateTimeKind.Local).AddTicks(1911), "AQAAAAIAAYagAAAAEAq7U2scrOKZ/n7+aBdLS004AP025zPjia2B61FZYdCFL4hGb9eS/UnC6ez4LB6nVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7566971c-7da1-48da-9588-74dd3730b441", new DateTime(2023, 11, 22, 10, 47, 19, 946, DateTimeKind.Local).AddTicks(4912), new DateTime(2023, 11, 22, 10, 47, 19, 946, DateTimeKind.Local).AddTicks(4924), "AQAAAAIAAYagAAAAEKFo7LqLSMrrI3x4lyyzZ+7GbmUMkqi9C8X6E8s8LCFxNSv1PA7gVT4uNKfXpAEnEw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f992548e-bf48-49ed-bffb-fb85343f1e8e", new DateTime(2023, 11, 22, 10, 47, 19, 807, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 11, 22, 10, 47, 19, 807, DateTimeKind.Local).AddTicks(5169), "AQAAAAIAAYagAAAAEO9VJIZGAIyujwIcd/svf24jc0u302NCEPjxqdw2XKfAwHpAWElNteXD/lmXr4DiHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1f87b5d9-9d67-422f-a86a-60d1eb5a53b6", new DateTime(2023, 11, 22, 10, 47, 19, 737, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 11, 22, 10, 47, 19, 737, DateTimeKind.Local).AddTicks(2477), "AQAAAAIAAYagAAAAEENrthauNVNEmEpLd9rMZBZLmZKQ2HAtRtCuVQBr2IuQabXRjotUEyOrevz7amBaBw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9495), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9582), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9597), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9611), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9624), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9652), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9671), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9756), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9698), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9835), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9861), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9871), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9896), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9913), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9852), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9863), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9881), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9897), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9854), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9874), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9882), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9899), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9907), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9915), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9855), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9866), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9900), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9908), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9916), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9856), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9867), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9876), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9909), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9867), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9877), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9893), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9859), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9869), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9894), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9903), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9870), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9904), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9920), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9970), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9980), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9985), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9960), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9966), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9986), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9982), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9992), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9997), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9973), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9983), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9988), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9963), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9969), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9989), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9994), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9999), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9999) });
        }
    }
}
