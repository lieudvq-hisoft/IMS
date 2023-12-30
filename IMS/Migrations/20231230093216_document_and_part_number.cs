using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class document_and_part_number : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RemovalFilePath",
                table: "ServerAllocations",
                newName: "RemovalReceiptFilePath");

            migrationBuilder.RenameColumn(
                name: "FinalRemoval",
                table: "ServerAllocations",
                newName: "RemovalInspectFilePath");

            migrationBuilder.AddColumn<string>(
                name: "FinalRemovalInspect",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FinalRemovalReceipt",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNumber",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalRemovalInspect",
                table: "ServerAllocations");

            migrationBuilder.DropColumn(
                name: "FinalRemovalReceipt",
                table: "ServerAllocations");

            migrationBuilder.DropColumn(
                name: "PartNumber",
                table: "ServerAllocations");

            migrationBuilder.RenameColumn(
                name: "RemovalReceiptFilePath",
                table: "ServerAllocations",
                newName: "RemovalFilePath");

            migrationBuilder.RenameColumn(
                name: "RemovalInspectFilePath",
                table: "ServerAllocations",
                newName: "FinalRemoval");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5812), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5828), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "0621caf6-b05c-4bcc-b450-d15025d34c76", new DateTime(2023, 12, 30, 14, 55, 12, 12, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 12, 30, 14, 55, 12, 12, DateTimeKind.Local).AddTicks(2937), new List<string>(), "AQAAAAIAAYagAAAAECIIIS6RugSTrswdPaJnBJr6bPub1tZypkBxPgvzOWQkS5tyiqVf0fCzqnkRusaxnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "d985daa2-0650-4079-b8e4-f7a98eddd23f", new DateTime(2023, 12, 30, 14, 55, 12, 93, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 12, 30, 14, 55, 12, 93, DateTimeKind.Local).AddTicks(6331), new List<string>(), "AQAAAAIAAYagAAAAENtig5mJdntkdamsJzROSi5ODrjgYBrLaavBKb7JHR3Hg9ezfWcF+m43Zxc3+cST7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c3a77483-4813-4113-8930-c5678bd925d8", new DateTime(2023, 12, 30, 14, 55, 11, 939, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 12, 30, 14, 55, 11, 939, DateTimeKind.Local).AddTicks(7550), new List<string>(), "AQAAAAIAAYagAAAAEBjW9O+m+2mP1aI/v5eYpEHqRXAAQaEGrD0q+UaB9KOx6CElJFGDL64A1XXrfEBDSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "95b8967d-13cb-4a77-82c0-4f6b47d78263", new DateTime(2023, 12, 30, 14, 55, 11, 869, DateTimeKind.Local).AddTicks(266), new DateTime(2023, 12, 30, 14, 55, 11, 869, DateTimeKind.Local).AddTicks(279), new List<string>(), "AQAAAAIAAYagAAAAEHbL0r5G//0Y0dJgVIiC39toqwm/WW0u1aULrXRdenlHeeYwFYhFy7Hb/RblwZH0Vw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5634), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5780), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5794), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5835), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5858), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5885), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5895), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5914), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5896), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5923), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5897), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5933), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5842), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5880), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5898), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5925), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5843), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5881), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5891), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5900), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5909), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5926), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5846), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5882), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5892), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5910), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5936), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5848), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5911), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5996), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5884), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5903), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5997), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5999), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6002), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6008), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6013), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6024), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6035), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6004), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6010), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6026), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6032), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6005), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6016), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6027), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6038), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 12, 30, 14, 55, 11, 863, DateTimeKind.Local).AddTicks(6044) });
        }
    }
}
