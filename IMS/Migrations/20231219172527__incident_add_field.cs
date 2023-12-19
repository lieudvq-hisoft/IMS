using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class _incident_add_field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsResolvByClient",
                table: "Incidents",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6706), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "8058a32f-5630-4b6e-bbe5-763f4f95e9aa", new DateTime(2023, 12, 20, 0, 25, 26, 76, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 12, 20, 0, 25, 26, 76, DateTimeKind.Local).AddTicks(2908), new List<string>(), "AQAAAAIAAYagAAAAECKDN/In6EfXgSpOguVN2tJIGWF8EHjW5ZfLMc2EM1JBi6NRNP2qYXnAt3kJAc7hGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "59a72948-f37c-4a77-bb68-2ab3703f344f", new DateTime(2023, 12, 20, 0, 25, 26, 215, DateTimeKind.Local).AddTicks(4702), new DateTime(2023, 12, 20, 0, 25, 26, 215, DateTimeKind.Local).AddTicks(4715), new List<string>(), "AQAAAAIAAYagAAAAEDHnadfsN9NZAlAwoEzrXCjQFhuIjTwEZfKYwovJJScBuWajivvlfF+7ucG709E1mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "e01d4519-e3c2-4546-ae78-cb782dcde95a", new DateTime(2023, 12, 20, 0, 25, 25, 983, DateTimeKind.Local).AddTicks(4244), new DateTime(2023, 12, 20, 0, 25, 25, 983, DateTimeKind.Local).AddTicks(4263), new List<string>(), "AQAAAAIAAYagAAAAEEuRQ0o/7eczvYzGYt/bzxGf8K7nxXbE9vP1gnpRLk9FeNp8yR2jmdeCKRLxhHBFtw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "777296a8-e3cc-4894-84b7-8a2b194ae872", new DateTime(2023, 12, 20, 0, 25, 25, 869, DateTimeKind.Local).AddTicks(6814), new DateTime(2023, 12, 20, 0, 25, 25, 869, DateTimeKind.Local).AddTicks(6824), new List<string>(), "AQAAAAIAAYagAAAAEPgEmhaHq82gNS/FjJEz1AHM3y/Af9GRItyyDDb00sOa9AP9n4aNhiEZGnfSDngzmg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6665), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6672), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6752), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6771), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6817), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6826), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6841), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6763), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6827), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6842), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6718), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6755), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6765), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6773), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6820), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6828), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6836), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6843), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6719), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6766), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6774), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6829), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6844), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6775), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6830), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6845), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6758), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6768), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6823), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6831), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6846), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6759), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6769), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6839), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6847), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6816), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6825), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6833), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6861), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6866), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6871), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6857), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6876), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6881), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6886), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6853), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6858), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6868), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6887), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6854), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6859), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6864), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6869), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6873), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6878), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6883), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6888), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6855), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6869), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6874), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6879), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6884), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6889), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6889) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsResolvByClient",
                table: "Incidents");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5492), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "57b0306c-1c5a-41de-b322-77595244583b", new DateTime(2023, 12, 20, 0, 24, 16, 969, DateTimeKind.Local).AddTicks(6622), new DateTime(2023, 12, 20, 0, 24, 16, 969, DateTimeKind.Local).AddTicks(6640), new List<string>(), "AQAAAAIAAYagAAAAEMx33bXPsszjeqRMt6LQGTmEi4G+eMWq+aNuW1d/+lm13ba55f8fAj/lywA6C3aMZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b2c96cb6-5d83-45a4-b337-5189489e9127", new DateTime(2023, 12, 20, 0, 24, 17, 80, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 12, 20, 0, 24, 17, 80, DateTimeKind.Local).AddTicks(4112), new List<string>(), "AQAAAAIAAYagAAAAEI9Js1m7GJGL5vPjTSpAwp8pjWOVHZoX8lwZ/uY/XBmytcd3IBHA7AhdSaz4pC3Kmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "d0325052-718a-4a95-b6a7-e622638cdf18", new DateTime(2023, 12, 20, 0, 24, 16, 842, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 12, 20, 0, 24, 16, 842, DateTimeKind.Local).AddTicks(7547), new List<string>(), "AQAAAAIAAYagAAAAEM3NW2dZz49rCXFjPSt/wkQoEkPv/tr+nj0v1txAI9ECHzYqsPfsOb+pBapYi3ilvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "1becc79c-f6c1-46b7-a2c9-e83a8e4b309a", new DateTime(2023, 12, 20, 0, 24, 16, 742, DateTimeKind.Local).AddTicks(6432), new DateTime(2023, 12, 20, 0, 24, 16, 742, DateTimeKind.Local).AddTicks(6444), new List<string>(), "AQAAAAIAAYagAAAAENXDJgo0B/iF6eMyfae2ZhfJs3dGo/kU73oNRXltmE0RZZTtnC2Ip/iUo04EK6F12Q==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5257), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5367), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5378), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5387), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5448), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5513), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5561), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5571), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5518), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5572), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5582), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5591), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5519), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5565), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5593), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5555), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5566), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5585), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5594), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5602), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5526), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5567), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5576), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5595), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5612), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5547), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5557), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5568), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5577), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5613), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5558), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5569), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5588), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5614), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5549), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5579), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5616), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5686), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5691), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5713), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5719), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5680), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5687), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5698), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5704), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5709), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5682), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5688), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5694), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5699), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5705), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5689), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5695), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5706), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5711), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5716), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5684), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5696), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5707), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 12, 20, 0, 24, 16, 737, DateTimeKind.Local).AddTicks(5724) });
        }
    }
}
