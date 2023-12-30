using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class tax_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_TaxNumber",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5812), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5828), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "0621caf6-b05c-4bcc-b450-d15025d34c76", new DateTime(2023, 12, 30, 14, 55, 12, 12, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 12, 30, 14, 55, 12, 12, DateTimeKind.Local).AddTicks(2937), new List<string>(), "AQAAAAIAAYagAAAAECIIIS6RugSTrswdPaJnBJr6bPub1tZypkBxPgvzOWQkS5tyiqVf0fCzqnkRusaxnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "d985daa2-0650-4079-b8e4-f7a98eddd23f", new DateTime(2023, 12, 30, 14, 55, 12, 93, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 12, 30, 14, 55, 12, 93, DateTimeKind.Local).AddTicks(6331), new List<string>(), "AQAAAAIAAYagAAAAENtig5mJdntkdamsJzROSi5ODrjgYBrLaavBKb7JHR3Hg9ezfWcF+m43Zxc3+cST7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c3a77483-4813-4113-8930-c5678bd925d8", new DateTime(2023, 12, 30, 14, 55, 11, 939, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 12, 30, 14, 55, 11, 939, DateTimeKind.Local).AddTicks(7550), new List<string>(), "AQAAAAIAAYagAAAAEBjW9O+m+2mP1aI/v5eYpEHqRXAAQaEGrD0q+UaB9KOx6CElJFGDL64A1XXrfEBDSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "95b8967d-13cb-4a77-82c0-4f6b47d78263", new DateTime(2023, 12, 30, 14, 55, 11, 869, DateTimeKind.Local).AddTicks(266), new DateTime(2023, 12, 30, 14, 55, 11, 869, DateTimeKind.Local).AddTicks(279), new List<string>(), "AQAAAAIAAYagAAAAEHbL0r5G//0Y0dJgVIiC39toqwm/WW0u1aULrXRdenlHeeYwFYhFy7Hb/RblwZH0Vw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5634), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5780), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5794), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5835), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5858), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5885), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5895), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5914), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5896), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5923), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5897), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5933), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5842), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5880), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5898), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5925), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5843), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5881), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5891), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5900), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5909), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5926), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5846), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5882), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5892), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5910), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5936), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5848), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5911), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5996), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5884), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5903), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5997), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5999), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6002), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6008), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6013), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6024), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6035), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6004), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6010), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6026), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6032), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6005), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6016), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6027), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6038), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6044) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6582), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c9fc4e71-0c4a-4817-b4a4-4aea30aee8bf", new DateTime(2023, 12, 29, 23, 41, 1, 178, DateTimeKind.Local).AddTicks(7151), new DateTime(2023, 12, 29, 23, 41, 1, 178, DateTimeKind.Local).AddTicks(7169), new List<string>(), "AQAAAAIAAYagAAAAEAs8ouxvXugAILVoSLOtEtAoEU2BONw8FiQe03HfxuR5G+w8FDYkZI4iLBVxJw0Tag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "6c6e6343-3b97-46f0-a703-0a984a77d329", new DateTime(2023, 12, 29, 23, 41, 1, 325, DateTimeKind.Local).AddTicks(8901), new DateTime(2023, 12, 29, 23, 41, 1, 325, DateTimeKind.Local).AddTicks(8918), new List<string>(), "AQAAAAIAAYagAAAAEJlh6ojiKVxbDNn6+nOwtCfuxdlHhUA9SV/hWCYZZ4Jd56ZI5/QXprR0OOVqfUigbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a108cd19-ecde-4a8e-bb91-f74248c7b382", new DateTime(2023, 12, 29, 23, 41, 1, 50, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 12, 29, 23, 41, 1, 50, DateTimeKind.Local).AddTicks(2940), new List<string>(), "AQAAAAIAAYagAAAAEJJOcSX1+fXUieRMXp9vu/1x/Z0jNpO4HF/+uh70nxsB7FAbdla258VZwI6fFnZmpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "2e3e1ed4-2c8e-4b01-bd2e-276dcbc4e22b", new DateTime(2023, 12, 29, 23, 41, 0, 930, DateTimeKind.Local).AddTicks(87), new DateTime(2023, 12, 29, 23, 41, 0, 930, DateTimeKind.Local).AddTicks(103), new List<string>(), "AQAAAAIAAYagAAAAEIZsvwTcvaNJDxvE8oi9sZnYLoBHEqNa1HCqcUEeXPDzE+HFUNQ9W/RgDnxMhAS8Zw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6389), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6541), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6643), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6651), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6668), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6592), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6636), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6653), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6661), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6669), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6593), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6638), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6645), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6654), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6662), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6712), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6595), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6638), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6663), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6713), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6595), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6639), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6656), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6664), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6671), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6598), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6631), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6657), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6665), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6672), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6715), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6641), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6649), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6666), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6673), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6601), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6633), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6642), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6659), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6667), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6708), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6717), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6718), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6752), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6721), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6727), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6732), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6737), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6742), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6748), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6753), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6758), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6722), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6728), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6733), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6738), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6743), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6759), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6723), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6734), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6739), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6744), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6755), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6724), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6735), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6745), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6751), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TaxNumber",
                table: "Customers",
                column: "TaxNumber",
                unique: true);
        }
    }
}
