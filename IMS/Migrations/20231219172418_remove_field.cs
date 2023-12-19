using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class remove_field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
