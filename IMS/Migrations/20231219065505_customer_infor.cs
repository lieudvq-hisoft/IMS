using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class customer_infor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractNumber",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RepresentatorPosition",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6663), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "12c7060e-8f11-4ff6-9484-8ba20dea1417", new DateTime(2023, 12, 19, 13, 55, 4, 458, DateTimeKind.Local).AddTicks(2183), new DateTime(2023, 12, 19, 13, 55, 4, 458, DateTimeKind.Local).AddTicks(2194), new List<string>(), "AQAAAAIAAYagAAAAEBSKYysoKYTfL0D/+RBLRmdo+67vJyQyzRfJyzeq5hjM28zRWCuCm66wMH3VF2ZVPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "111b3eaf-7d98-4aba-92f5-771d879c6b9f", new DateTime(2023, 12, 19, 13, 55, 4, 543, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 12, 19, 13, 55, 4, 543, DateTimeKind.Local).AddTicks(7426), new List<string>(), "AQAAAAIAAYagAAAAEN40+9TRR6gQ9Js+s8lRUJ88l6WKUNHxJnZeIHbOIvTJioB0gXwbNbo+DR5A9+Il2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "51b8078e-65f6-4c07-950d-8570218f46cf", new DateTime(2023, 12, 19, 13, 55, 4, 347, DateTimeKind.Local).AddTicks(8228), new DateTime(2023, 12, 19, 13, 55, 4, 347, DateTimeKind.Local).AddTicks(8240), new List<string>(), "AQAAAAIAAYagAAAAEF5uvu28DbCkwnv5GhReJXtlT6wSSQo84ZEymZGY+yHKTOgWPTgavdQd3MlqV874+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "d0cead16-ac68-46af-a837-04478c5de499", new DateTime(2023, 12, 19, 13, 55, 4, 154, DateTimeKind.Local).AddTicks(9390), new DateTime(2023, 12, 19, 13, 55, 4, 154, DateTimeKind.Local).AddTicks(9399), new List<string>(), "AQAAAAIAAYagAAAAEKp7u1hrwZtQ7DuY8ssphjwsOcgXfc0h71nWVmPwZV/rn6cyGd6H6FBQRzBG+prCJQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6614), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6639), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6788), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6797), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6806), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6814), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6830), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6790), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6807), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6823), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6831), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6839), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6763), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6791), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6808), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6816), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6839), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6801), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6809), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6817), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6825), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6833), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6765), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6793), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6802), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6818), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6826), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6841), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6774), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6794), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6803), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6811), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6827), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6842), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6775), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6795), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6804), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6812), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6820), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6828), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6836), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6843), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6786), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6812), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6829), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6844), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6846), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6909), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6918), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6923), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6928), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6933), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6914), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6919), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6924), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6929), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6934), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6915), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6920), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6925), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6935), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6850), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6911), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6916), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6921), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6926), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6931), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6936), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6851), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6908), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6912), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6917), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6922), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6927), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6932), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6937), new DateTime(2023, 12, 19, 13, 55, 4, 147, DateTimeKind.Local).AddTicks(6937) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RepresentatorPosition",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(347), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "cd4b60e6-f309-4f9e-9c84-d0d22e26452e", new DateTime(2023, 12, 19, 0, 15, 29, 203, DateTimeKind.Local).AddTicks(2762), new DateTime(2023, 12, 19, 0, 15, 29, 203, DateTimeKind.Local).AddTicks(2779), new List<string>(), "AQAAAAIAAYagAAAAEIyicmSoEZYG0Cq+MdUfQFJrFaT4l79jTUfhAmqrf4kNMqFpgYqFPbW0gHmtOIjMSA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a6ebcd91-fa98-45e8-bc63-8b091368f440", new DateTime(2023, 12, 19, 0, 15, 29, 281, DateTimeKind.Local).AddTicks(426), new DateTime(2023, 12, 19, 0, 15, 29, 281, DateTimeKind.Local).AddTicks(437), new List<string>(), "AQAAAAIAAYagAAAAEOf4UyqP1xgHVEa6Qkb7zXEEx3uSyyW/C4FQZJYtX2zSPDG8FyIyVEHr4h27uW/7pA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b9cbfc91-0031-4ff0-b8a9-cd420e1da6ec", new DateTime(2023, 12, 19, 0, 15, 29, 132, DateTimeKind.Local).AddTicks(484), new DateTime(2023, 12, 19, 0, 15, 29, 132, DateTimeKind.Local).AddTicks(496), new List<string>(), "AQAAAAIAAYagAAAAEAIzb/JupV36W+hY3+mpssbJWtZ8NtS9sHwkBy5g9GO1DXfZFXjrxqbFDNyHzmY7JA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7849ab1d-68dd-4b30-817b-fefcb36de348", new DateTime(2023, 12, 19, 0, 15, 29, 45, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 12, 19, 0, 15, 29, 45, DateTimeKind.Local).AddTicks(9683), new List<string>(), "AQAAAAIAAYagAAAAENy0kJZ3Rwgv78ZcBVYeaKQErewhGLkwL2WY4X2BdcNtKw6PkNIXuf1dsrYTBNaY7Q==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(197), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(307), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(397), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(448), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(458), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(485), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(493), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(501), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(468), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(477), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(486), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(494), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(502), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(413), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(452), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(461), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(469), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(479), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(495), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(503), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(453), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(462), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(480), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(488), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(496), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(454), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(472), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(480), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(489), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(546), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(455), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(481), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(490), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(456), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(465), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(482), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(491), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(499), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(548), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(447), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(457), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(475), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(483), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(492), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(549), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(557), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(562), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(567), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(572), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(577), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(582), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(587), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(558), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(563), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(568), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(573), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(578), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(583), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(588), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(554), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(564), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(569), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(574), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(579), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(584), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(589), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(555), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(560), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(570), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(575), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(580), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(585), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(590), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(556), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(561), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(566), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(571), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(576), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(581), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(586), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(591), new DateTime(2023, 12, 19, 0, 15, 29, 41, DateTimeKind.Local).AddTicks(591) });
        }
    }
}
