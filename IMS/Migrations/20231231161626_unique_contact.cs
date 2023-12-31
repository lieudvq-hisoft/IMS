using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class unique_contact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5366), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5381), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "3113b371-fe1b-407d-b288-e044da01deb1", new DateTime(2023, 12, 31, 23, 16, 25, 503, DateTimeKind.Local).AddTicks(6452), new DateTime(2023, 12, 31, 23, 16, 25, 503, DateTimeKind.Local).AddTicks(6463), new List<string>(), "AQAAAAIAAYagAAAAEDMqVnhFgqckYAuR343jjRnGB6f3v3uwg69gak3S6HK3fPaHLRN+MMghYE40HWPL2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7a1bec93-329d-4692-b236-0b79ddbafc20", new DateTime(2023, 12, 31, 23, 16, 25, 570, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 12, 31, 23, 16, 25, 570, DateTimeKind.Local).AddTicks(3197), new List<string>(), "AQAAAAIAAYagAAAAEBqwlhSLx++aXN4xnM+wvScw2ODlsZZO9VJ1DSBaINYF6+8gJepEdzxmR84rwFEX4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "227f6dcc-05be-4819-a58e-8f46337b72ad", new DateTime(2023, 12, 31, 23, 16, 25, 436, DateTimeKind.Local).AddTicks(5667), new DateTime(2023, 12, 31, 23, 16, 25, 436, DateTimeKind.Local).AddTicks(5678), new List<string>(), "AQAAAAIAAYagAAAAEDpZgxYmkMxqUO5Fa4kjwkT28QLgQsG+qpXSuOh+Nh1r/2hA9Lti8oqUtly2E5NQow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "d0544ebb-e305-4ae8-bec4-149afa16bf3e", new DateTime(2023, 12, 31, 23, 16, 25, 369, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 12, 31, 23, 16, 25, 369, DateTimeKind.Local).AddTicks(7469), new List<string>(), "AQAAAAIAAYagAAAAEN86uRxikN3WYiEZ365gWZqwOLO+CFHncN4p15FR5Y2D7j8H2EbiCpneRO8ZMTkdng==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5261), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5339), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5351), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5386), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5442), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5451), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5459), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5513), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5521), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5434), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5444), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5452), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5461), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5514), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5522), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5392), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5436), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5453), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5462), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5515), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5393), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5436), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5446), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5463), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5524), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5531), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5394), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5447), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5455), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5464), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5517), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5532), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5396), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5439), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5448), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5456), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5465), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5518), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5526), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5533), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5397), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5449), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5519), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5534), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5406), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5458), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5512), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5535), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5537), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5558), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5564), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5569), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5539), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5565), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5545), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5555), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5561), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5566), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5571), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5576), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5541), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5546), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5562), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5567), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5572), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5577), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5542), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5547), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5557), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5568), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5573), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 12, 31, 23, 16, 25, 365, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Email",
                table: "Contacts",
                column: "Email",
                unique: true,
                filter: "\"IsDeleted\" = false");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PhoneNumber",
                table: "Contacts",
                column: "PhoneNumber",
                unique: true,
                filter: "\"IsDeleted\" = false");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contacts_Email",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_PhoneNumber",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7816), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7835), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "5f878c6e-d41d-4fae-8e69-555ec05d1fe0", new DateTime(2023, 12, 30, 16, 32, 14, 665, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 12, 30, 16, 32, 14, 665, DateTimeKind.Local).AddTicks(846), new List<string>(), "AQAAAAIAAYagAAAAEANlScRfxSeCtu4wkXGht3FEoS3O7l0f7s0GRBcML9TD9vPS2uJp3ezuLnkNREh75w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "5cbddb4d-c855-4830-80b6-72c40c4106ad", new DateTime(2023, 12, 30, 16, 32, 14, 758, DateTimeKind.Local).AddTicks(9306), new DateTime(2023, 12, 30, 16, 32, 14, 758, DateTimeKind.Local).AddTicks(9326), new List<string>(), "AQAAAAIAAYagAAAAEF9nKglO71+Kz/w4y2j+ClRahykWNFGzN8N64DTtAqPkq+YJhFPZNhLYSqUa380+EA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c40c8126-14dd-40e3-9f59-896fa31db14c", new DateTime(2023, 12, 30, 16, 32, 14, 570, DateTimeKind.Local).AddTicks(7395), new DateTime(2023, 12, 30, 16, 32, 14, 570, DateTimeKind.Local).AddTicks(7420), new List<string>(), "AQAAAAIAAYagAAAAEJT1T4XOlzz2jrBPlqIMFgmDhSDNQGMHrg8HhC3KgMPSN/hTcJzLwBvl/M9D3C7ltA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "16a432a0-dde9-48b8-ba39-38f95b460c76", new DateTime(2023, 12, 30, 16, 32, 14, 473, DateTimeKind.Local).AddTicks(1856), new DateTime(2023, 12, 30, 16, 32, 14, 473, DateTimeKind.Local).AddTicks(1866), new List<string>(), "AQAAAAIAAYagAAAAEMos+dVAYmms1vs0ncjOmzNUnEa6IlRORl0qWjIte/bZuMXk1XZO7A0j6JGvIXB0RQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7587), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7771), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7786), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7842), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7847), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7931), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7948), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7957), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7848), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7941), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7849), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7933), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7942), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7959), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7934), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7943), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7951), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7983), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7944), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7855), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7936), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7953), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7977), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7985), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7937), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7946), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7954), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7963), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7987), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7994), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7999), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8004), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8008), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8075), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8080), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8085), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7990), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7995), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8005), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8009), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8076), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8081), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8086), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7996), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8001), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8006), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8082), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7992), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8011), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8078), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8083), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8088), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7993), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7998), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8003), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8073), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8084), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8089), new DateTime(2023, 12, 30, 16, 32, 14, 465, DateTimeKind.Local).AddTicks(8090) });
        }
    }
}
