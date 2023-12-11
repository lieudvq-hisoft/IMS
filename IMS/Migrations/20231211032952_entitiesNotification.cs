using System;
using System.Collections.Generic;
using Data.Entities;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class entitiesNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<string>>(
                name: "FcmTokens",
                table: "AspNetUsers",
                type: "text[]",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Seen = table.Column<bool>(type: "boolean", nullable: false),
                    Action = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<NotificationData>(type: "jsonb", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "5ab0f581-3d23-46fd-b21f-4501b12f1a3d", new DateTime(2023, 12, 11, 10, 29, 52, 54, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 12, 11, 10, 29, 52, 54, DateTimeKind.Local).AddTicks(7810), null, "AQAAAAIAAYagAAAAEKYP49FfFFlrvlFVxGOfZZum2WF0CkMWSWlu7iyxVWL4z5g+2fuXJ8s0CoF8q/PcQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "9b7588bd-09b1-4825-bb2d-b7a86b77f85a", new DateTime(2023, 12, 11, 10, 29, 52, 94, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 12, 11, 10, 29, 52, 94, DateTimeKind.Local).AddTicks(120), null, "AQAAAAIAAYagAAAAEPZIDsA7X5J4gQEp8qpOSa8nWdjrg5B3zv2HryJxONYrkf4JZK1Jd07mrbYWYBIBqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "134159c5-30d0-4b4b-b1df-911afeff1f5c", new DateTime(2023, 12, 11, 10, 29, 52, 10, DateTimeKind.Local).AddTicks(9640), new DateTime(2023, 12, 11, 10, 29, 52, 10, DateTimeKind.Local).AddTicks(9680), null, "AQAAAAIAAYagAAAAELd9gxYmRAH2LbdBqyUXYJF6i6PGnRFBboopa162SpvAu5o34i6tiGJ4jAFiLoCimA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "cb1384b8-c6b6-40d6-9709-4e45f3a4255f", new DateTime(2023, 12, 11, 10, 29, 51, 971, DateTimeKind.Local).AddTicks(3180), new DateTime(2023, 12, 11, 10, 29, 51, 971, DateTimeKind.Local).AddTicks(3180), null, "AQAAAAIAAYagAAAAEGnyu3fvg3elrtVsnkDJH+K6/buoRwfB7Y+wzzQ1Oa+KmFqmKuqGe0WS2jhgwYLzEQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 12, 11, 10, 29, 51, 968, DateTimeKind.Local).AddTicks(9010) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropColumn(
                name: "FcmTokens",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9955), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0302d5e0-e0d4-40fe-a692-1ab89724236b", new DateTime(2023, 12, 10, 23, 0, 57, 423, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 12, 10, 23, 0, 57, 423, DateTimeKind.Local).AddTicks(6039), "AQAAAAIAAYagAAAAEMTkWzkszP11lqHC1r4s5xsu3JaRM4Z/ryK4zT2c5at3MqMAAw0IH5p7jZIM503e1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "cc1cd818-856d-4956-ad02-4dd1fd3e3703", new DateTime(2023, 12, 10, 23, 0, 57, 530, DateTimeKind.Local).AddTicks(4317), new DateTime(2023, 12, 10, 23, 0, 57, 530, DateTimeKind.Local).AddTicks(4339), "AQAAAAIAAYagAAAAEL5SG5mzApzghb1Qg58LBnB/ELMPCzAyd4TAatVUoH1GsLH0eeZVBTPRFdNOALVaig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "11c11153-bb8e-4efc-92db-911858329668", new DateTime(2023, 12, 10, 23, 0, 57, 340, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 12, 10, 23, 0, 57, 340, DateTimeKind.Local).AddTicks(3069), "AQAAAAIAAYagAAAAEGaVw8g8RzAbdHTbip5CM0bvMivXbuzpgCjOd9couIP7I2UM3lz+iy6tJJcDwq+VBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bcd359f5-ea8c-4c3c-af46-c8c273df790e", new DateTime(2023, 12, 10, 23, 0, 57, 225, DateTimeKind.Local).AddTicks(4294), new DateTime(2023, 12, 10, 23, 0, 57, 225, DateTimeKind.Local).AddTicks(4305), "AQAAAAIAAYagAAAAEJA4j2pEhzXdZ8frXcbs1sYWwa0d0npQoVDW/N5c+u9itlxkzL7CzuljgoiGUWCqTA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9898), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(106), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(151), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(174), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(198), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(219), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(239), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(14), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(84), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(132), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(155), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(179), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(199), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(221), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(243), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(135), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(158), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(182), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(203), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(246), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(19), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(91), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(159), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(183), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(227), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(247), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(92), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(140), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(163), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(187), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(207), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(229), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(248), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(27), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(96), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(143), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(166), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(190), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(211), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(232), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(250), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(49), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(99), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(168), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(191), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(235), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(102), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(171), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(195), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(253), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(270), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(300), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(349), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(376), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(257), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(286), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(303), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(335), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(353), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(289), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(306), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(267), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(292), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(328), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(342), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(359), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(386), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(296), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(330), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(346), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(389) });
        }
    }
}
