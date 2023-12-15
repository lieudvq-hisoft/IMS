using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class upgrade_port : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "RequestHosts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsUpgrade",
                table: "RequestHosts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "IpAssignments",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4981), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "d1012c43-2157-4a57-8319-62dcdc378615", new DateTime(2023, 12, 16, 0, 15, 5, 567, DateTimeKind.Local).AddTicks(5582), new DateTime(2023, 12, 16, 0, 15, 5, 567, DateTimeKind.Local).AddTicks(5598), new List<string>(), "AQAAAAIAAYagAAAAEFaNkUwYsaXcqsA6NIFfLg7F9VxdpbG7eLg+KbYVgv/JQanjSSMm0hvzpgUxPEkGiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "8d3ac826-8926-44c2-9c82-1a162308d2db", new DateTime(2023, 12, 16, 0, 15, 5, 682, DateTimeKind.Local).AddTicks(1916), new DateTime(2023, 12, 16, 0, 15, 5, 682, DateTimeKind.Local).AddTicks(1927), new List<string>(), "AQAAAAIAAYagAAAAEIAXWSLlMh/e9J1YPgQVxVqoed4pdzTTzR+ug3lDyWlt15g/3WO/gy4/u2TFflzSmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "2cff053b-f858-40de-bfae-6e6cd8ab8cde", new DateTime(2023, 12, 16, 0, 15, 5, 301, DateTimeKind.Local).AddTicks(4936), new DateTime(2023, 12, 16, 0, 15, 5, 301, DateTimeKind.Local).AddTicks(4948), new List<string>(), "AQAAAAIAAYagAAAAEM/hwNGBKlOPq/QBdtVrzq4dP/1Zs3A31rIkkGultobYlsxmOlFnntcfyZJu2zx4LQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "6494099c-4e4c-4aea-b9ca-a6f7132e9ede", new DateTime(2023, 12, 16, 0, 15, 5, 154, DateTimeKind.Local).AddTicks(9869), new DateTime(2023, 12, 16, 0, 15, 5, 154, DateTimeKind.Local).AddTicks(9881), new List<string>(), "AQAAAAIAAYagAAAAEHvVglFxqEtfJe5FhT+Lm/ElbljSzmFB71FBSNZsz3MMtZRyQ3DTybvlWvfw3FbExg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4779), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4904), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4923), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4950), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5010), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5060), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5177), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5202), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5015), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5062), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5179), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5203), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5017), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5193), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5205), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5019), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5143), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5155), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5169), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5182), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5194), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5020), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5145), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5196), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5035), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5146), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5172), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5197), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5148), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5186), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5211), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5135), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5188), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5201), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5213), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5215), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5225), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5241), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5258), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5343), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5353), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5218), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5227), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5235), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5243), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5251), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5259), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5346), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5355), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5229), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5237), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5245), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5253), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5261), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5348), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5356), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5222), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5238), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5246), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5254), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5262), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5358), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5232), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5248), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5256), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5264), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5351), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5359), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5360) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "RequestHosts");

            migrationBuilder.DropColumn(
                name: "IsUpgrade",
                table: "RequestHosts");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "IpAssignments");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5742), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "bcc7d9a6-4e97-4f10-a287-6a729392340c", new DateTime(2023, 12, 13, 13, 5, 46, 954, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 12, 13, 13, 5, 46, 955, DateTimeKind.Local).AddTicks(9), new List<string>(), "AQAAAAIAAYagAAAAEIxlxk9HJHVF4cmHQgTznEDFUvaGCxowmnnLAVPykCvbqrul6H+r7ebzJuQ4R5GfCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "926b5b58-be45-4487-8d73-08cdeea4b604", new DateTime(2023, 12, 13, 13, 5, 47, 26, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 12, 13, 13, 5, 47, 26, DateTimeKind.Local).AddTicks(9728), new List<string>(), "AQAAAAIAAYagAAAAEFyGvcBhmxMxGKy/2081wKHKDhcWS9OilIU0spq5Nw3N3kUJSnsBWhpfaltNPze/lw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b0f0c86e-97bc-4a3e-ab64-00b2c0866359", new DateTime(2023, 12, 13, 13, 5, 46, 883, DateTimeKind.Local).AddTicks(7076), new DateTime(2023, 12, 13, 13, 5, 46, 883, DateTimeKind.Local).AddTicks(7087), new List<string>(), "AQAAAAIAAYagAAAAEHz9eoEGvpSs5G9bz0J2MFxOmouoR3hs1il14ahdmj8V93sLrS2lF1Pn5Qshu5XL7w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "9055ae4c-7adc-4185-a442-63f436643576", new DateTime(2023, 12, 13, 13, 5, 46, 810, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 12, 13, 13, 5, 46, 810, DateTimeKind.Local).AddTicks(3497), new List<string>(), "AQAAAAIAAYagAAAAEHL3VMebCS1E97OtP93VGgbw3IAF7eHDKsTVR4jC2SLQGZK11IztZfy0MCAdSBtw7w==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5573), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5662), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5675), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5685), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5704), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5747), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5786), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5804), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5812), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5835), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5788), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5797), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5805), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5813), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5828), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5836), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5754), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5798), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5806), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5814), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5829), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5837), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5755), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5791), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5799), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5807), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5823), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5830), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5838), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5792), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5808), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5824), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5831), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5765), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5793), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5801), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5809), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5825), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5766), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5794), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5802), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5818), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5826), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5833), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5785), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5795), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5803), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5826), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5834), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5843), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5860), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5865), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5870), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5880), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5885), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5851), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5866), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5876), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5881), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5886), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5862), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5882), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5858), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5868), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5859), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5864), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5874), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5884), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5889), new DateTime(2023, 12, 13, 13, 5, 46, 805, DateTimeKind.Local).AddTicks(5889) });
        }
    }
}
