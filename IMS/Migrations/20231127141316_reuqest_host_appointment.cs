using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class reuqest_host_appointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestHostAppointments");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "294f3cda-6dc8-453f-a22d-475948298b31", new DateTime(2023, 11, 27, 21, 13, 16, 87, DateTimeKind.Local).AddTicks(3317), new DateTime(2023, 11, 27, 21, 13, 16, 87, DateTimeKind.Local).AddTicks(3328), "AQAAAAIAAYagAAAAEBVaeduHRHvmpZ1A6RUWGl7t6nKbd2yO9SjyS8pUtpoIpvsBAQIIqyzqCDSXWadLLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "76555446-a9f8-44c2-beb6-f8be0f296263", new DateTime(2023, 11, 27, 21, 13, 15, 950, DateTimeKind.Local).AddTicks(269), new DateTime(2023, 11, 27, 21, 13, 15, 950, DateTimeKind.Local).AddTicks(282), "AQAAAAIAAYagAAAAELjf+2lS3PRHNPa7Rl856LnREOgsTSa7ea7Oft99wmwVP5/hxY4v0jLhsRbeq3JssA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "36f2260b-f4d8-4260-8ff1-82f4acb6c759", new DateTime(2023, 11, 27, 21, 13, 16, 19, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 11, 27, 21, 13, 16, 19, DateTimeKind.Local).AddTicks(6845), "AQAAAAIAAYagAAAAEC6s1nR+l16M3LFoSnoP2roP5eXE21bI97K5AJY/I+rR/3PqjyPy6zQXGLMDenD2ug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "22ec75bf-9ee1-458e-acc9-414156bfb2a8", new DateTime(2023, 11, 27, 21, 13, 15, 882, DateTimeKind.Local).AddTicks(7163), new DateTime(2023, 11, 27, 21, 13, 15, 882, DateTimeKind.Local).AddTicks(7177), "AQAAAAIAAYagAAAAEBKl9vSfwNt5vwhEIuEOfw2m32/tgx5INexfNPFnhkSqFPl3+1rJ6w9ni1EUFl/WaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2ed2deed-d12d-4fda-b4ea-b2a93134f42d", new DateTime(2023, 11, 27, 21, 13, 15, 815, DateTimeKind.Local).AddTicks(9935), new DateTime(2023, 11, 27, 21, 13, 15, 815, DateTimeKind.Local).AddTicks(9947), "AQAAAAIAAYagAAAAEEQxff/4QgF0uyg9sOUmS9uF5DMqJiVdVPTrOFl1F4QNZNjIlM3tTmy0ZeiEL/WOfA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2647), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2668), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2678), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2805), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2921), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2929), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2937), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2945), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2906), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2914), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2930), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2938), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2945), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2907), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2915), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2939), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2946), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2899), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2908), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2932), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2947), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2812), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2909), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2917), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2926), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2933), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2941), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2948), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2918), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2926), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2934), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2949), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2902), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2927), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2935), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2943), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2903), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2928), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2944), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2951), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2964), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2965), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2961), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2971), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2975), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3019), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3024), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2962), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2967), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2976), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3015), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3020), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2968), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3026) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestHostAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    RequestHostId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestHostAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestHostAppointments_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestHostAppointments_RequestHosts_RequestHostId",
                        column: x => x.RequestHostId,
                        principalTable: "RequestHosts",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "30a44537-98b2-4f3c-a203-9f58949aedca", new DateTime(2023, 11, 27, 15, 10, 22, 69, DateTimeKind.Local).AddTicks(905), new DateTime(2023, 11, 27, 15, 10, 22, 69, DateTimeKind.Local).AddTicks(917), "AQAAAAIAAYagAAAAECCYyshO3gwuREUBzEucX6aSFE5kqaDZXNCB2/M/xjbsljB1YNHLIfzBD4aQ5pxhzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c40bb087-f12a-4384-b272-98d689eca407", new DateTime(2023, 11, 27, 15, 10, 21, 921, DateTimeKind.Local).AddTicks(330), new DateTime(2023, 11, 27, 15, 10, 21, 921, DateTimeKind.Local).AddTicks(343), "AQAAAAIAAYagAAAAEI6BIQ1MFcPX1tiGeOQViGhJuLS5yihSgqQBNiYbVrd+BJNpy/QPmIqdwCmwAuNQGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c054a28e-db7f-4cff-b24a-563ead9c4a71", new DateTime(2023, 11, 27, 15, 10, 21, 999, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 11, 27, 15, 10, 21, 999, DateTimeKind.Local).AddTicks(880), "AQAAAAIAAYagAAAAENGNEIVn5nJkAM4aOdOC+9LBq6xd9Kff1pHBT87b6kf6gDD3CkNi8AKIKxHuPe4Vcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "db39c13c-3bcb-4f53-b295-01eab83619ad", new DateTime(2023, 11, 27, 15, 10, 21, 776, DateTimeKind.Local).AddTicks(1477), new DateTime(2023, 11, 27, 15, 10, 21, 776, DateTimeKind.Local).AddTicks(1491), "AQAAAAIAAYagAAAAEKhC+sfKGXkRvsRQNYJPEGFEn0Zp3LOyEy19MDfbS2kkYA++x7WE4VYWqlpSAgD+4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "00628366-998c-4b0e-9c77-3e681312076c", new DateTime(2023, 11, 27, 15, 10, 21, 679, DateTimeKind.Local).AddTicks(1978), new DateTime(2023, 11, 27, 15, 10, 21, 679, DateTimeKind.Local).AddTicks(1990), "AQAAAAIAAYagAAAAEOMaHauVFXOHFr2Rt4Zn2NGjxYWDph3I0qLRV7LV5a2Y8+qnuDUiRKHksG0/RkfJ6A==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8509), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8525), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8574), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8592), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8657), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8701), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8673), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8757), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8813), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8822), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8838), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8778), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8816), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8824), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8817), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8826), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8835), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8812), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8821), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8829), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8914), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8919), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8925), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8916), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8921), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8941), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8912), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8917), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8927), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8907), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8913), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8923), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8928), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.CreateIndex(
                name: "IX_RequestHostAppointments_AppointmentId",
                table: "RequestHostAppointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestHostAppointments_RequestHostId",
                table: "RequestHostAppointments",
                column: "RequestHostId");
        }
    }
}
