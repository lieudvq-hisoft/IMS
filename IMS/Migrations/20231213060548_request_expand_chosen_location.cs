using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_expand_chosen_location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChosenLocation",
                table: "RequestExpands",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChosenLocation",
                table: "RequestExpands");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "26f29340-16de-496d-9f3b-91815ee77011", new DateTime(2023, 12, 11, 22, 43, 41, 898, DateTimeKind.Local).AddTicks(1795), new DateTime(2023, 12, 11, 22, 43, 41, 898, DateTimeKind.Local).AddTicks(1816), new List<string>(), "AQAAAAIAAYagAAAAEBvOBtJbup+OVl+8b8Upo1Kd07BKnHtpr1NhrRMh9PmgIKwszM8qWqWtMiuyFY9MAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b3aeef53-81d4-48df-9a79-d23f6c35b301", new DateTime(2023, 12, 11, 22, 43, 41, 995, DateTimeKind.Local).AddTicks(4105), new DateTime(2023, 12, 11, 22, 43, 41, 995, DateTimeKind.Local).AddTicks(4121), new List<string>(), "AQAAAAIAAYagAAAAEFesRP8YkdSJWrycegJJ44wChniP+I40u9XzwvVptvhSgSZU6CNsvYB+TM0vH7cpkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a038ce09-fbed-45cf-bd96-bc8fb33c60ed", new DateTime(2023, 12, 11, 22, 43, 41, 790, DateTimeKind.Local).AddTicks(1128), new DateTime(2023, 12, 11, 22, 43, 41, 790, DateTimeKind.Local).AddTicks(1139), new List<string>(), "AQAAAAIAAYagAAAAEHirXGsbzdtlNhZ/+0QDbB+bqmjpNzdkj0XOhXGiVswqgJuQPpfBy5r6LKogc+fbZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "93cb07d2-1907-4dd0-a6e0-64f48df2dc54", new DateTime(2023, 12, 11, 22, 43, 41, 699, DateTimeKind.Local).AddTicks(847), new DateTime(2023, 12, 11, 22, 43, 41, 699, DateTimeKind.Local).AddTicks(857), new List<string>(), "AQAAAAIAAYagAAAAECfEsYM0Fi5av4kI4GvOeHcZ8Oyy7UCb9kSJojEGMxka1qVFkePE8vybBOii8fAp6g==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(1887), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2037), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2063), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2085), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2106), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2186), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2320), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2342), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2354), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2367), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2308), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2344), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2323), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2335), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2357), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2324), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2336), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2347), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2359), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2371), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2299), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2313), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2337), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2348), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2361), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2373), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2253), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2300), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2327), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2362), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2375), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2269), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2329), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2351), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2364), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2376), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2365), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2378), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2392), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2402), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2411), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2459), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2468), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2385), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2403), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2460), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2470), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2387), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2396), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2405), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2454), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2462), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2389), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2398), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2455), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2464), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2473), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2579), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2391), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2409), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2457), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2466), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 12, 11, 22, 43, 41, 685, DateTimeKind.Local).AddTicks(2581) });
        }
    }
}
