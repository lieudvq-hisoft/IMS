using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class requets_host_removal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRemoval",
                table: "RequestHosts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bc250a92-631f-4549-ad84-5fab072b1e06", new DateTime(2023, 12, 2, 0, 12, 28, 537, DateTimeKind.Local).AddTicks(3913), new DateTime(2023, 12, 2, 0, 12, 28, 537, DateTimeKind.Local).AddTicks(3926), "AQAAAAIAAYagAAAAEHDxbeAW8b3vLTB2QcWCTuCEP+YhZ+bJ7Og8SKkoHaTfbFAwPTrgKnoO9lv8frtj+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "63f677fe-05d6-4c02-ad93-1116bef71323", new DateTime(2023, 12, 2, 0, 12, 28, 393, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 12, 2, 0, 12, 28, 393, DateTimeKind.Local).AddTicks(2819), "AQAAAAIAAYagAAAAEC3zdix4iXnzWyOC5yZ1y5I9GU/Y3VGdOIAnGejlB7mHhAXwU4SDaWVb+QN7oEWq0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3a603012-0910-469c-b9f5-1e37eb99a57c", new DateTime(2023, 12, 2, 0, 12, 28, 462, DateTimeKind.Local).AddTicks(831), new DateTime(2023, 12, 2, 0, 12, 28, 462, DateTimeKind.Local).AddTicks(844), "AQAAAAIAAYagAAAAEBVdXzhyCDE8FqFLdgN7srS2CpfIQFPs7CQkluHKq/zf8yg+cq33hNMW3b5x1LTb1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3ef61fdd-410d-43f1-9c36-80ac89ad556a", new DateTime(2023, 12, 2, 0, 12, 28, 318, DateTimeKind.Local).AddTicks(4002), new DateTime(2023, 12, 2, 0, 12, 28, 318, DateTimeKind.Local).AddTicks(4015), "AQAAAAIAAYagAAAAEGlhWrwztV5TnutditCUNN8II4Br+eKMpT4FwzaUZAAq+XHh4rg9KxKcQRAeMxzElA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9bdac291-9a93-4a9f-95cc-b96567bc0c0a", new DateTime(2023, 12, 2, 0, 12, 28, 251, DateTimeKind.Local).AddTicks(3158), new DateTime(2023, 12, 2, 0, 12, 28, 251, DateTimeKind.Local).AddTicks(3168), "AQAAAAIAAYagAAAAECIAsLMihCuEYDB1070pH4/XrUs73ywnLdJfaVQ77ft632kmNHt/LFqQeaLT2y5/cA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8529), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8733), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8845), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8869), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8893), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8816), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8888), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8895), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8914), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8919), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8925), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8901), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8916), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8921), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8907), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8912), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8917), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8927), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8903), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8913), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8923), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8927), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8938) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRemoval",
                table: "RequestHosts");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5958), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c85c1d21-7286-440c-8d2e-b8fa2f70f9d8", new DateTime(2023, 12, 1, 0, 1, 35, 474, DateTimeKind.Local).AddTicks(7306), new DateTime(2023, 12, 1, 0, 1, 35, 474, DateTimeKind.Local).AddTicks(7321), "AQAAAAIAAYagAAAAELtOerEUjqXcRGqBSQBT6tgme593xkYIUXrfSvpj8/EygMtS8muuQj9Szj+iRiKttQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "393752a2-6523-4fad-a378-29156930148f", new DateTime(2023, 12, 1, 0, 1, 35, 217, DateTimeKind.Local).AddTicks(1418), new DateTime(2023, 12, 1, 0, 1, 35, 217, DateTimeKind.Local).AddTicks(1435), "AQAAAAIAAYagAAAAEHvhV6Ho7kyvwlLckCaXRg7YVP88I3pByHuczGl7rSDobWE7sZ3KhKRNsPXMykuGBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a5d71fa2-7004-49e7-a854-c69dfba0ee2f", new DateTime(2023, 12, 1, 0, 1, 35, 361, DateTimeKind.Local).AddTicks(7467), new DateTime(2023, 12, 1, 0, 1, 35, 361, DateTimeKind.Local).AddTicks(7487), "AQAAAAIAAYagAAAAELRcFnjEsRvcqchNyYqEIe1chDJToUlc7CQjsPyQ1AbetmRdPxrcueE9IcQknKtKAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4c77f8d5-0db7-4fdb-bece-a84936c49b2a", new DateTime(2023, 12, 1, 0, 1, 35, 133, DateTimeKind.Local).AddTicks(872), new DateTime(2023, 12, 1, 0, 1, 35, 133, DateTimeKind.Local).AddTicks(887), "AQAAAAIAAYagAAAAECTikpfMo7848oGPjZ5a9Z9enm0KgVHjReJEVGjXJ5snVrQ1wFxbmfMpFnPDbLKTBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "be67ad1c-7a25-4008-ba73-70f02b043ce4", new DateTime(2023, 12, 1, 0, 1, 35, 49, DateTimeKind.Local).AddTicks(2129), new DateTime(2023, 12, 1, 0, 1, 35, 49, DateTimeKind.Local).AddTicks(2142), "AQAAAAIAAYagAAAAELHzM1Ez+6qPAOIfD3qG0G+JNvDkxs9k/3WMNbi/6EaNPB1dW+1yJRGdm2cXO46yjw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5787), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5913), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5997), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6052), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6061), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6069), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6077), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6129), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6137), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6054), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6070), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6078), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6138), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6013), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6071), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6079), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6131), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6139), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6064), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6072), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6080), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6132), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6065), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6073), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6081), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6133), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6141), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6058), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6082), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6134), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6142), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6059), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6083), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6135), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6051), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6127), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6136), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6144), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6145), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6152), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6157), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6162), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6167), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6172), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6177), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6183), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6147), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6158), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6163), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6173), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6178), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6184), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6149), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6154), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6159), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6164), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6169), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6174), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6180), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6185), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6149), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6155), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6160), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6165), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6170), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6175), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6181), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6186), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6150), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6156), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6161), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6166), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6176), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6182), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6187), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6187) });
        }
    }
}
