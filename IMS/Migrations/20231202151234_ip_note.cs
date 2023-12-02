using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class ip_note : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestHosts");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "IpAddresses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3889c68e-0745-429e-818f-95749094a297", new DateTime(2023, 12, 2, 22, 12, 31, 823, DateTimeKind.Local).AddTicks(8154), new DateTime(2023, 12, 2, 22, 12, 31, 823, DateTimeKind.Local).AddTicks(8167), "AQAAAAIAAYagAAAAEGSrJOnqM9tDgH41t4RYv5tgTSN0WqbHk7h5u9GVGYOACV4b5hcCZ4Y1mlYhJ6n6LQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "79d35c75-6c48-407d-8aee-22a5ef61fde7", new DateTime(2023, 12, 2, 22, 12, 31, 550, DateTimeKind.Local).AddTicks(7806), new DateTime(2023, 12, 2, 22, 12, 31, 550, DateTimeKind.Local).AddTicks(7820), "AQAAAAIAAYagAAAAEKJSO1IqQhsXkgPsItGSddmVXJewMlLiCg+vBJNCrAurv5KbbFLIN0+olnVUCn6JsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "fc68af79-4b0c-44e8-875b-3bf204d66297", new DateTime(2023, 12, 2, 22, 12, 31, 696, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 12, 2, 22, 12, 31, 696, DateTimeKind.Local).AddTicks(5622), "AQAAAAIAAYagAAAAEJbvc9CEf4wFlZaPOwfdPwp2FV2e5FsvzuFFpceBGgNk6om/k+49G8wQ1qB3Ec1z5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3fb043a7-2f1f-4c11-93b2-07e0b45329ee", new DateTime(2023, 12, 2, 22, 12, 31, 392, DateTimeKind.Local).AddTicks(3306), new DateTime(2023, 12, 2, 22, 12, 31, 392, DateTimeKind.Local).AddTicks(3326), "AQAAAAIAAYagAAAAED8qirbotkFuddIXi29oBsLzmoFFb8wAPtTjwCm8b71NZhqU/bOYJ2Q1ccgr8hzxRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "484bf6a5-ea8a-47b2-a701-622ff9ffa15f", new DateTime(2023, 12, 2, 22, 12, 31, 249, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 12, 2, 22, 12, 31, 249, DateTimeKind.Local).AddTicks(3277), "AQAAAAIAAYagAAAAEAgQt6qGsuXWzCXkBewqAQ+oVIzq/S4LD//FYK+ZBGviEIFILNsbZMhP4icFtbthxQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8517), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8646), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8662), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8703), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8674), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8917), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9023), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8947), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8877), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8893), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8895), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8928), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8953), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9032), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8913), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8955), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9034), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9060), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9071), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9081), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9100), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9052), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9062), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9072), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9082), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9101), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9044), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9054), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9064), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9074), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9084), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9103), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9114), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9046), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9056), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9066), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9076), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9086), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9105), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9116), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9058), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9078), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9088), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9108), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9118), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9119) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "IpAddresses");

            migrationBuilder.AddColumn<string>(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestHosts",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8584), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8602), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2e2fff36-8c9d-4013-8929-c603d1e26d32", new DateTime(2023, 12, 2, 2, 23, 39, 929, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 12, 2, 2, 23, 39, 929, DateTimeKind.Local).AddTicks(2872), "AQAAAAIAAYagAAAAEMSRanIwgq1uboe/MA3sgUxyHK3oF7l3Rhv7gig+2io6ct9Xrh9iu4roHJ1kIaqSMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a7ab0918-7af8-4fef-bfde-206d54b454c8", new DateTime(2023, 12, 2, 2, 23, 39, 777, DateTimeKind.Local).AddTicks(7315), new DateTime(2023, 12, 2, 2, 23, 39, 777, DateTimeKind.Local).AddTicks(7330), "AQAAAAIAAYagAAAAEImGUorixbqAxxGDbuanODOX6eYajFAtThj8u7aPlAGzZhJmnHYRj67d7vKirAivsQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "83c7842b-499b-4d1a-ba91-b39938fe5690", new DateTime(2023, 12, 2, 2, 23, 39, 858, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 12, 2, 2, 23, 39, 858, DateTimeKind.Local).AddTicks(1115), "AQAAAAIAAYagAAAAEMf8PFjn8VO/S4uex1l5NNsbD6qHbuYSzttpWO6aYeKvrOZweQeA183zB8YxWW2kTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "49bbf27a-205e-4563-b6bf-258e8ef37bcd", new DateTime(2023, 12, 2, 2, 23, 39, 693, DateTimeKind.Local).AddTicks(969), new DateTime(2023, 12, 2, 2, 23, 39, 693, DateTimeKind.Local).AddTicks(980), "AQAAAAIAAYagAAAAEIRkuig4pnA74sZg7VYzvKSf6D81ohbhQS7gjpMWVPF170EOXiW6Lkr2EGWnbEp+gQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "02288414-b77f-418e-9e80-c73fa4cde2ab", new DateTime(2023, 12, 2, 2, 23, 39, 616, DateTimeKind.Local).AddTicks(2408), new DateTime(2023, 12, 2, 2, 23, 39, 616, DateTimeKind.Local).AddTicks(2421), "AQAAAAIAAYagAAAAEAdXFaPDGJM1g0JNnKZ0bfTCvwlRHhCRgopGToGh3ft3WCUw6YzveIZ2tygpCLj5JA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8402), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8519), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8559), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8531), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8609), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8646), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8736), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8614), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8647), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8738), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8615), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8649), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8738), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8616), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8763), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8757), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8651), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8733), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8734), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8742), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8766), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8774), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8760), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8782), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8845), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8778), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 12, 2, 2, 23, 39, 610, DateTimeKind.Local).AddTicks(8854) });
        }
    }
}
