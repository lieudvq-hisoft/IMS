using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class ip_blocking_history : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IpHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateExecuted = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsBlock = table.Column<bool>(type: "boolean", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    IpAddressId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpHistories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IpHistories_IpAddresses_IpAddressId",
                        column: x => x.IpAddressId,
                        principalTable: "IpAddresses",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "85f2b6a1-09e7-484f-a33f-aad130d05a30", new DateTime(2024, 1, 7, 12, 11, 58, 641, DateTimeKind.Local).AddTicks(359), new DateTime(2024, 1, 7, 12, 11, 58, 641, DateTimeKind.Local).AddTicks(377), new List<string>(), "AQAAAAIAAYagAAAAEIkOaLpF4tQKc3N9nqEfOEzlV65yxuqojdRkt8nOLQYLdAFcz2ofErU+6UUZ6CbdjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "26b99cbe-6678-49fc-b248-310b176ce6dd", new DateTime(2024, 1, 7, 12, 11, 58, 708, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 1, 7, 12, 11, 58, 708, DateTimeKind.Local).AddTicks(4520), new List<string>(), "AQAAAAIAAYagAAAAEMUt8D3RIpK5q3l80JHXsnkGi/4eIb1oHYV9LZeGahmFdKTNRGGZHQsbU/NcyNimig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b368917d-af9d-4f88-9e72-4d3c5aa9ac21", new DateTime(2024, 1, 7, 12, 11, 58, 573, DateTimeKind.Local).AddTicks(372), new DateTime(2024, 1, 7, 12, 11, 58, 573, DateTimeKind.Local).AddTicks(387), new List<string>(), "AQAAAAIAAYagAAAAED/KZYhDFBpXg2NTpyrr1GDZi7U3DyU92VdHV3QV/FTSHujA6k1E2Eb4tO81/FXveQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "51712f64-6a82-4f12-b947-4b639c33eace", new DateTime(2024, 1, 7, 12, 11, 58, 500, DateTimeKind.Local).AddTicks(304), new DateTime(2024, 1, 7, 12, 11, 58, 500, DateTimeKind.Local).AddTicks(309), new List<string>(), "AQAAAAIAAYagAAAAEFRt2XknGhp2mqRElEpWBpyTAlpxg/BF0YB/v527l4ROuW9oPQL1DdxjAPLVOQu4Fw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8577), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8610), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8616), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8726), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8742), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8718), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8619), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8654), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8736), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8744), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8620), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8656), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8730), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8624), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8666), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8722), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8658), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8667), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8723), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8755), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8757), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8763), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8768), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8773), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8778), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8783), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8759), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8764), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8769), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8779), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8784), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8789), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8760), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8765), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8775), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8780), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8795), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8766), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8776), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8791), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8796), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8762), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8772), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8777), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8782), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8792), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8797), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.CreateIndex(
                name: "IX_IpHistories_IpAddressId",
                table: "IpHistories",
                column: "IpAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_IpHistories_UserId",
                table: "IpHistories",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IpHistories");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(509), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(521), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a6e5ebec-83e8-40eb-8f92-8ab0959324b3", new DateTime(2024, 1, 6, 12, 22, 27, 986, DateTimeKind.Local).AddTicks(7262), new DateTime(2024, 1, 6, 12, 22, 27, 986, DateTimeKind.Local).AddTicks(7277), new List<string>(), "AQAAAAIAAYagAAAAEEsjv9kK7Qo9o+94L4/RzMWzrfK1ZT3qcrKLCmhEQ++mwqBDQQMhTPCv76wFmb5pbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "9991c306-be41-45e4-9bc4-e6bbedf6048b", new DateTime(2024, 1, 6, 12, 22, 28, 72, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 1, 6, 12, 22, 28, 72, DateTimeKind.Local).AddTicks(2248), new List<string>(), "AQAAAAIAAYagAAAAEBia25aA2C5b37zsfSN0KP4Kl48h0A42c4cfp8drIApcQLLoRlvrELHUOWxz1vildw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "fa1fdf10-21ad-47a4-a743-d052aa3b17fa", new DateTime(2024, 1, 6, 12, 22, 27, 915, DateTimeKind.Local).AddTicks(8752), new DateTime(2024, 1, 6, 12, 22, 27, 915, DateTimeKind.Local).AddTicks(8765), new List<string>(), "AQAAAAIAAYagAAAAEOF55jVzAjuFZPJWWav8IU2gOIqZWxxdAkdlqhV3h5l5HBCMJ/jL2C05PU1hLPTmvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "0e8b0073-6c37-4746-be57-83c0f7e98c52", new DateTime(2024, 1, 6, 12, 22, 27, 843, DateTimeKind.Local).AddTicks(9646), new DateTime(2024, 1, 6, 12, 22, 27, 843, DateTimeKind.Local).AddTicks(9658), new List<string>(), "AQAAAAIAAYagAAAAEM6dWGk3Bfety1Ih12KNYlm4WbhTyA/biXofkVAFB4bkC6YNPU99OIXEg2PBwKSnMA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(341), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(548), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(567), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(642), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(650), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(532), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(559), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(609), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(618), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(627), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(635), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(651), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(561), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(644), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(652), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(535), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(562), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(637), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(645), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(653), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(536), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(613), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(621), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(654), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(539), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(564), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(614), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(639), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(655), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(540), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(565), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(623), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(632), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(648), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(656), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(547), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(566), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(616), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(633), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(641), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(666), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(672), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(677), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(682), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(687), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(692), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(727), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(662), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(673), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(678), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(683), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(688), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(728), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(663), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(668), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(674), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(679), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(684), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(689), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(694), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(729), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(669), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(675), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(680), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(725), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(730), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(671), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(676), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(681), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(686), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(691), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(726), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 1, 6, 12, 22, 27, 841, DateTimeKind.Local).AddTicks(731) });
        }
    }
}
