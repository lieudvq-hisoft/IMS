using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class client_resolv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResolvByClient",
                table: "Incidents",
                newName: "IsResolvByClient");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "00da1aa2-7fcc-4417-9b59-48725b7d5ed2", new DateTime(2023, 12, 20, 0, 16, 14, 517, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 12, 20, 0, 16, 14, 517, DateTimeKind.Local).AddTicks(2973), new List<string>(), "AQAAAAIAAYagAAAAEJyHANWkH/KRga8A/GqVRZ1UdbCML1vduTA32GvEugvNBP4CnRrOgaW5YMOFXg4diQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "f28c3457-3eea-404c-a056-074f44129fe6", new DateTime(2023, 12, 20, 0, 16, 14, 672, DateTimeKind.Local).AddTicks(9043), new DateTime(2023, 12, 20, 0, 16, 14, 672, DateTimeKind.Local).AddTicks(9065), new List<string>(), "AQAAAAIAAYagAAAAEKjHBYZG0HqhtAKD0CNBTbxIENwUYXp+cnW2ru1qIn4VDU0DnlgSFS9f9CPzi1cAJg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "34d00c3b-5df8-42c8-ab19-08844986df51", new DateTime(2023, 12, 20, 0, 16, 14, 414, DateTimeKind.Local).AddTicks(838), new DateTime(2023, 12, 20, 0, 16, 14, 414, DateTimeKind.Local).AddTicks(856), new List<string>(), "AQAAAAIAAYagAAAAEFzTR3/dfsVE9nPaAt+4BbeKQ4u2dC4vDdfvU2/ufuNLN/caWRbvevNXq92+kGNRCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "3035b9f3-2bf9-436a-a0b4-437d321f3792", new DateTime(2023, 12, 20, 0, 16, 14, 266, DateTimeKind.Local).AddTicks(2554), new DateTime(2023, 12, 20, 0, 16, 14, 266, DateTimeKind.Local).AddTicks(2569), new List<string>(), "AQAAAAIAAYagAAAAEIu9b5AWp1rgp1amqWYL/Ha8/WeJlov1bPtYsJYkaERc3yva3PK47tWi+B4QBsb+9g==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6119), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6138), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6151), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6163), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6223), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6376), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6394), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6408), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6435), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6447), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6231), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6383), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6397), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6410), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6424), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6436), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6449), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6461), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6233), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6385), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6412), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6426), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6438), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6451), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6235), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6386), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6401), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6413), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6427), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6452), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6464), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6388), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6402), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6415), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6429), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6441), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6389), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6404), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6416), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6430), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6443), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6467), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6391), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6405), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6431), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6444), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6469), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6392), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6407), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6420), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6433), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6446), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6458), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6472), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6483), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6498), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6555), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6563), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6476), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6484), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6491), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6499), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6548), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6557), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6564), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6572), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6478), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6493), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6558), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6566), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6573), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6479), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6487), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6494), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6502), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6552), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6575), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6481), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6488), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6496), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6503), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6561), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6569), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6577), new DateTime(2023, 12, 20, 0, 16, 14, 260, DateTimeKind.Local).AddTicks(6577) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsResolvByClient",
                table: "Incidents",
                newName: "ResolvByClient");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2551), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a44b10af-f4c2-4f6a-a52e-e65f388dcff4", new DateTime(2023, 12, 20, 0, 13, 46, 532, DateTimeKind.Local).AddTicks(6495), new DateTime(2023, 12, 20, 0, 13, 46, 532, DateTimeKind.Local).AddTicks(6510), new List<string>(), "AQAAAAIAAYagAAAAEHgiXB3BR/TCrAMr/idNQaDvMqUVGHDt8BMKyQKESbgd3EalcAra3CzwwMYcVftuQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "ad0312a7-175d-40be-93d2-bf5f24f584b6", new DateTime(2023, 12, 20, 0, 13, 46, 654, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 12, 20, 0, 13, 46, 654, DateTimeKind.Local).AddTicks(7307), new List<string>(), "AQAAAAIAAYagAAAAEHKQ0X20T0OK1y9Ap9gxIVM4t45zeZaIwJFjrjanQ3m4gz8qcTWfgTZ4ZU2YVdK88Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "4cfa7c48-ff1d-466b-a64e-cf9984b3aa50", new DateTime(2023, 12, 20, 0, 13, 46, 426, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 12, 20, 0, 13, 46, 426, DateTimeKind.Local).AddTicks(3219), new List<string>(), "AQAAAAIAAYagAAAAEPyxlK5WY8Qk2S/+/r3KZPOAAG6VwPt8teuBVONdojK5EcUmmWh1RwVY2yTtKbJYCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "82b3e90c-0c0e-4907-8c11-ebe751d174c8", new DateTime(2023, 12, 20, 0, 13, 46, 333, DateTimeKind.Local).AddTicks(4897), new DateTime(2023, 12, 20, 0, 13, 46, 333, DateTimeKind.Local).AddTicks(4913), new List<string>(), "AQAAAAIAAYagAAAAEPJoSBaOCWFkA598YEbjs1KKUXfNHli3Ld9VyZYk7wwZCBJxhu319qJ7/lGScpQ35w==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2418), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2507), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2524), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2611), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2627), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2636), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2693), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2604), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2613), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2621), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2629), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2637), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2644), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2622), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2637), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2645), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2606), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2615), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2631), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2638), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2646), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2616), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2624), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2632), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2639), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2647), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2696), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2617), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2633), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2689), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2588), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2609), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2618), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2641), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2619), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2626), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2635), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2699), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2702), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2709), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2724), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2728), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2733), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2738), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2704), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2714), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2716), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2721), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2716), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2731), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2707), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2723), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2737), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 12, 20, 0, 13, 46, 329, DateTimeKind.Local).AddTicks(2742) });
        }
    }
}
