using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class filepath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InspectionRecordFilePath",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptOfRecipientFilePath",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RemovalFilePath",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3280), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f655f15a-c30c-410f-a2a8-1be9b992a5c6", new DateTime(2023, 12, 5, 22, 1, 41, 530, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 12, 5, 22, 1, 41, 530, DateTimeKind.Local).AddTicks(4110), "AQAAAAIAAYagAAAAEPV0Op4AF21MihvyQQLwJsIlV/MlhCb35soZbboye6jn2pCv8p7EUj4SiV5KzLWZhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "465c46f9-eac0-4a93-b5f3-c413648a7d01", new DateTime(2023, 12, 5, 22, 1, 41, 388, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 12, 5, 22, 1, 41, 388, DateTimeKind.Local).AddTicks(1147), "AQAAAAIAAYagAAAAEByWpisVMAFz1gbmPCqDCAEmup7GnO5tP9M2MptkoOsg0lRDlZLeTUVe63NzAE/TXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "dcc357a1-c2c2-4cd7-8a76-170f74c75228", new DateTime(2023, 12, 5, 22, 1, 41, 460, DateTimeKind.Local).AddTicks(988), new DateTime(2023, 12, 5, 22, 1, 41, 460, DateTimeKind.Local).AddTicks(1000), "AQAAAAIAAYagAAAAEAK+pwL7VMkh1KKnblnuKuuDcpE0f0xxDdHgjkh2otLnDY+tvMXpRpI06s2Y+X9nPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f0e7afab-b79d-4b05-8944-83dffd3ec671", new DateTime(2023, 12, 5, 22, 1, 41, 320, DateTimeKind.Local).AddTicks(2093), new DateTime(2023, 12, 5, 22, 1, 41, 320, DateTimeKind.Local).AddTicks(2106), "AQAAAAIAAYagAAAAEL6zLAtVxk38dw3okboIlrA23f3lWr05kl0OTb6MCuWSu17yDHLPijnl0rd0/Fhrpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "cd558532-6df2-4287-9459-f4d2f81f1c47", new DateTime(2023, 12, 5, 22, 1, 41, 252, DateTimeKind.Local).AddTicks(6179), new DateTime(2023, 12, 5, 22, 1, 41, 252, DateTimeKind.Local).AddTicks(6182), "AQAAAAIAAYagAAAAEJAGJsmpjXV3jIXsbcdqwjoAu6dSdFWmwaWJtnE1YkNjGxZW13hDsMIg7hu5QsCgkA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3305), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3334), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3343), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3398), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3406), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3415), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3423), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3431), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3310), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3336), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3345), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3399), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3408), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3416), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3337), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3391), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3400), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3409), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3433), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3338), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3393), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3401), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3410), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3418), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3426), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3434), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3319), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3339), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3394), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3402), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3411), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3427), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3321), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3340), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3395), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3403), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3412), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3428), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3396), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3404), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3421), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3342), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3397), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3405), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3422), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3430), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3438), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3439), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3451), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3457), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3447), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3453), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3458), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3468), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3473), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3512), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3463), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3469), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3473), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3513), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3444), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3470), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3514), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3466), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3471), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3475), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3516) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InspectionRecordFilePath",
                table: "ServerAllocations");

            migrationBuilder.DropColumn(
                name: "ReceiptOfRecipientFilePath",
                table: "ServerAllocations");

            migrationBuilder.DropColumn(
                name: "RemovalFilePath",
                table: "ServerAllocations");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3774), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3788), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4585431d-025f-4a1b-aa7b-82b64d17acca", new DateTime(2023, 12, 5, 16, 28, 53, 31, DateTimeKind.Local).AddTicks(3998), new DateTime(2023, 12, 5, 16, 28, 53, 31, DateTimeKind.Local).AddTicks(4010), "AQAAAAIAAYagAAAAELcmhsg7VxDlblfNRRwvn+65csCcB0iH/He4HwMOxToompdE5dzHOadPbW3QDizSew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c469187c-7029-4de4-acb3-ae0dca1c3899", new DateTime(2023, 12, 5, 16, 28, 52, 869, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 12, 5, 16, 28, 52, 869, DateTimeKind.Local).AddTicks(2781), "AQAAAAIAAYagAAAAED/jrzfT7oQXIf4x5JNgL5iQEaTrmKFSfhC2qVVfCnLI1yTqxqKwWXYxkmQpaHq4lQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "eff9ee36-19e9-4307-957c-e5f9ae190ec8", new DateTime(2023, 12, 5, 16, 28, 52, 948, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 12, 5, 16, 28, 52, 948, DateTimeKind.Local).AddTicks(7332), "AQAAAAIAAYagAAAAEKB18ftcronzYHRYsXr/u8SKI7jaTlSQtgovWiwN6DdmaK+zc1Wquk3M1fdk+AEiXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8325e394-40db-4038-bf92-f919e3ebc4d5", new DateTime(2023, 12, 5, 16, 28, 52, 788, DateTimeKind.Local).AddTicks(3867), new DateTime(2023, 12, 5, 16, 28, 52, 788, DateTimeKind.Local).AddTicks(3879), "AQAAAAIAAYagAAAAECIb4+Gp3iJjtnvaxlw3e20Hikb7NzK8EMh1U04mCzYlB5MfZOZ02okCsvVvlxoFyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "5749a0bd-8f6b-4477-8d85-bf7491ce847e", new DateTime(2023, 12, 5, 16, 28, 52, 719, DateTimeKind.Local).AddTicks(7021), new DateTime(2023, 12, 5, 16, 28, 52, 719, DateTimeKind.Local).AddTicks(7028), "AQAAAAIAAYagAAAAEB5363bHv3e7aloYkJxRreXZWgdKFBLaIwz7t79P+Cfh+sGxVzCVDMrv8AQ9lrQIFQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3596), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3721), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3731), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3742), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3753), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3816), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3857), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3866), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3875), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3883), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3892), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3943), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3951), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3828), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3859), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3868), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3876), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3885), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3893), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3944), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3829), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3860), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3869), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3877), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3886), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3894), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3945), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3837), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3861), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3870), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3878), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3887), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3895), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3946), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3838), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3862), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3871), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3879), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3896), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3947), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3854), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3863), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3872), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3880), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3889), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3948), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3955), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3864), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3873), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3881), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3890), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3940), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3949), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3956), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3856), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3865), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3874), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3882), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3891), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3941), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3949), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3957), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3959), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3965), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3975), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3984), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3989), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3961), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3966), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3971), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3976), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3985), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3995), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3962), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3972), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3981), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3986), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3996), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3963), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3968), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3973), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3978), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3964), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3969), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3974), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3978), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3988), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3993), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3998), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3998) });
        }
    }
}
