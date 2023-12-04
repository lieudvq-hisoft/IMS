using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class ip_master_to_master_ip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IpMaster",
                table: "ServerAllocations",
                newName: "MasterIp");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6188), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6202), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b3daba6d-2548-4d17-83ae-c28ec74d65c4", new DateTime(2023, 12, 4, 16, 6, 7, 132, DateTimeKind.Local).AddTicks(617), new DateTime(2023, 12, 4, 16, 6, 7, 132, DateTimeKind.Local).AddTicks(629), "AQAAAAIAAYagAAAAEOui4pWmKMqj+szufGxd2vTH/VyKl0xZmhz53Q/Mc3gTufOLPZEdT9jwKeve7T5QrA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e3431dfd-c091-4ae6-a69d-939e92011b1a", new DateTime(2023, 12, 4, 16, 6, 6, 925, DateTimeKind.Local).AddTicks(8259), new DateTime(2023, 12, 4, 16, 6, 6, 925, DateTimeKind.Local).AddTicks(8270), "AQAAAAIAAYagAAAAEA4U07eE96gX+cSENMz6zNRWp30Ii4qRLIb1KsNi7LCIaM1mKFW3WFP+tyEs5ioixw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "af45e08c-8186-415a-9bf3-05360422faf3", new DateTime(2023, 12, 4, 16, 6, 7, 9, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 12, 4, 16, 6, 7, 9, DateTimeKind.Local).AddTicks(6997), "AQAAAAIAAYagAAAAELlvfsX9pJP1ELyGtE6rJYouAVnVsMW+9zEZIPC4qNuC9qi/RT+MgVGoiqY7DV2laQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "39a19a3f-a753-44b8-aa2a-f1456895c46e", new DateTime(2023, 12, 4, 16, 6, 6, 858, DateTimeKind.Local).AddTicks(67), new DateTime(2023, 12, 4, 16, 6, 6, 858, DateTimeKind.Local).AddTicks(79), "AQAAAAIAAYagAAAAEF2IsLtUefpYt+z1wGMbXh6tMmDJf3YndT+Ep7F8nz5aK4PukUeZQI2TFU7RDyOqpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7c1c5183-4599-4a88-ac22-91d5e1cb3a3c", new DateTime(2023, 12, 4, 16, 6, 6, 790, DateTimeKind.Local).AddTicks(5672), new DateTime(2023, 12, 4, 16, 6, 6, 790, DateTimeKind.Local).AddTicks(5679), "AQAAAAIAAYagAAAAEEhNsrghgfUJHJEz89YxlIbmqsDbD8hv9avod9AOFwiswxyFK70dohHb68/OcGvajA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6132), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6162), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6247), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6318), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6249), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6272), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6241), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6221), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6243), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6322), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6329), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6235), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6252), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6315), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6246), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6332), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6339), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6358), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6363), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6368), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6340), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6359), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6364), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6369), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6336), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6365), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6370), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6337), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6347), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6366), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6371), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6362), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6372), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6372) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MasterIp",
                table: "ServerAllocations",
                newName: "IpMaster");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5583), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3ad7d425-a2a1-44b8-bda0-c9b667da2995", new DateTime(2023, 12, 4, 15, 57, 44, 678, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 12, 4, 15, 57, 44, 678, DateTimeKind.Local).AddTicks(1243), "AQAAAAIAAYagAAAAEKpMIiBI761d1TeN/2bGhWEKkEeYCaP0LKd2AKyog8ruWgXoE5YzOB6Kel/3IEcONg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "75adc9c0-33b9-47d5-91e7-def7ae1771c4", new DateTime(2023, 12, 4, 15, 57, 44, 482, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 12, 4, 15, 57, 44, 482, DateTimeKind.Local).AddTicks(1830), "AQAAAAIAAYagAAAAEADrMyrTB8NdtN5O5tzXFYaWj4p1ywq7U51kzYW2SA5KkZbtDREOhYVBKXfU99Vnig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "800a44ac-055b-4a68-9735-315889982e17", new DateTime(2023, 12, 4, 15, 57, 44, 566, DateTimeKind.Local).AddTicks(4883), new DateTime(2023, 12, 4, 15, 57, 44, 566, DateTimeKind.Local).AddTicks(4896), "AQAAAAIAAYagAAAAEH5yAijHCWtno8CHKLIVcSjlA8V8F35YgMqeDQtJpYTNgXwVYqzOPDj3FU1pA+gAtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "58a16c70-b571-41e6-a65d-ff47fa246729", new DateTime(2023, 12, 4, 15, 57, 44, 410, DateTimeKind.Local).AddTicks(20), new DateTime(2023, 12, 4, 15, 57, 44, 410, DateTimeKind.Local).AddTicks(33), "AQAAAAIAAYagAAAAEH9eaBQpTS8QiaIvxL/LB+kufMrS9FloHjMgCd/vbY6y8VLEWB6/K59faSI7RWybIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b1ca7c4f-9386-4c3b-b6bc-10b34d06ab3c", new DateTime(2023, 12, 4, 15, 57, 44, 326, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 12, 4, 15, 57, 44, 326, DateTimeKind.Local).AddTicks(7903), "AQAAAAIAAYagAAAAEO0eRu/t/rHGsvkrSj80Y4Jxu7QGAW5uNFwbG0bLWYTICnakDpi/ZKYtERxk+Ea+wg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5428), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5535), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5562), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5643), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5699), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5724), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5732), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5739), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5645), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5709), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5740), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5646), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5702), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5726), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5741), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5618), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5711), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5719), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5727), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5734), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5742), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5648), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5704), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5735), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5743), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5649), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5705), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5713), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5736), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5744), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5641), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5650), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5706), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5737), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5745), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5642), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5707), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5738), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5746), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5747), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5753), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5758), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5763), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5768), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5772), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5848), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5749), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5754), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5759), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5764), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5769), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5773), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5755), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5765), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5774), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5751), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5766), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5775), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5757), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5762), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5767), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5771), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5846), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5851), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 12, 4, 15, 57, 44, 314, DateTimeKind.Local).AddTicks(5856) });
        }
    }
}
