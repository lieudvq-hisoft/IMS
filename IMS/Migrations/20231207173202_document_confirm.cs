using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class document_confirm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<bool>(
                name: "DocumentConfirm",
                table: "ServerAllocations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DocumentConfirm",
                table: "RequestHosts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DocumentConfirm",
                table: "Appointments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7554), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7563), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "191d58b0-cc98-4d54-914c-4c7ec69d5f0a", new DateTime(2023, 12, 8, 0, 31, 58, 991, DateTimeKind.Local).AddTicks(2244), new DateTime(2023, 12, 8, 0, 31, 58, 991, DateTimeKind.Local).AddTicks(2259), "AQAAAAIAAYagAAAAEAP83LGSdKtSvFTnVw8G7PVXSKwU5sggv8yrkSsb3YlJvERzgjkkt5V5N48TXDDcbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "200eae43-bfaa-4d29-b44a-2c31ff57c5bd", new DateTime(2023, 12, 8, 0, 31, 58, 573, DateTimeKind.Local).AddTicks(8912), new DateTime(2023, 12, 8, 0, 31, 58, 573, DateTimeKind.Local).AddTicks(8926), "AQAAAAIAAYagAAAAEBLKRQSkxnB2ezLA9Cacum27QV5uU6cK9x2pEgUNnHq6oSTDL7tMt/arBjN+Y7DzXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a8982d61-4231-431b-b8ed-f0f339faf912", new DateTime(2023, 12, 8, 0, 31, 58, 843, DateTimeKind.Local).AddTicks(272), new DateTime(2023, 12, 8, 0, 31, 58, 843, DateTimeKind.Local).AddTicks(299), "AQAAAAIAAYagAAAAEOjZjp9/FX9KOYdmoQh0Z/93ZGoBm1/yqKqyFoCeD4+tJPwYqE6f0GtreWe8qamieA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a6598b37-947a-4e51-8f4e-8a233e0b7505", new DateTime(2023, 12, 8, 0, 31, 58, 481, DateTimeKind.Local).AddTicks(9320), new DateTime(2023, 12, 8, 0, 31, 58, 481, DateTimeKind.Local).AddTicks(9337), "AQAAAAIAAYagAAAAEMjDXcaf3vuKV0kXbZdtLO//Obhvu4ZXaZ+rcNY3zC+S+FxImDMiNHzHWCioIXfT4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e3fbba18-5c6e-4bc7-a299-ced84084a44f", new DateTime(2023, 12, 8, 0, 31, 58, 386, DateTimeKind.Local).AddTicks(1928), new DateTime(2023, 12, 8, 0, 31, 58, 386, DateTimeKind.Local).AddTicks(1943), "AQAAAAIAAYagAAAAEPlDvbOh6HfE5jp8XDWCnUrBgPS0Ho3KYumVmhAXyyYQ9yixojDEOs64pO1JcEKNng==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7395), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7517), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7523), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7529), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7534), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7662), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7672), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7738), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7618), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7655), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7664), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7673), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7731), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7739), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7656), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7666), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7674), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7732), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7748), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7621), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7667), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7724), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7733), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7632), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7658), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7668), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7676), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7725), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7734), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7634), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7659), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7669), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7677), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7726), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7678), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7727), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7736), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7752), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7652), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7661), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7671), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7679), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7728), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7762), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7783), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7788), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7794), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7763), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7774), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7779), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7784), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7789), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7795), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7764), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7769), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7774), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7785), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7796), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7759), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7786), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7791), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7797), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7771), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7776), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7782), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7787), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7792), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7798), new DateTime(2023, 12, 8, 0, 31, 58, 383, DateTimeKind.Local).AddTicks(7798) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentConfirm",
                table: "ServerAllocations");

            migrationBuilder.DropColumn(
                name: "DocumentConfirm",
                table: "RequestHosts");

            migrationBuilder.DropColumn(
                name: "DocumentConfirm",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4425), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "562d9048-8730-4c01-80f5-c3d1e90e0cc0", new DateTime(2023, 12, 5, 23, 30, 52, 971, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 12, 5, 23, 30, 52, 971, DateTimeKind.Local).AddTicks(5210), "AQAAAAIAAYagAAAAEBUNLxK5bq36z7aaP9uwcTGWvXXhFgNTX9t8ACpyaSAvtnI6UzlWDc6Q3ugLg+zaow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8921e5fa-50d2-404f-aebd-15f0cc4ed7f1", new DateTime(2023, 12, 5, 23, 30, 52, 832, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 12, 5, 23, 30, 52, 832, DateTimeKind.Local).AddTicks(4615), "AQAAAAIAAYagAAAAEMaSl0AFCDFXAIODU4PwqZPGCmU0Jq3GUMrBQgWbwiXaQ8sckqRtZk83RWS0Q4fzmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "51c746bf-9f52-46b1-b119-6db642fc332a", new DateTime(2023, 12, 5, 23, 30, 52, 902, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 12, 5, 23, 30, 52, 902, DateTimeKind.Local).AddTicks(4063), "AQAAAAIAAYagAAAAEC9vFzD8OJPNQddjqvC7jPiRb1kvHB31JlmfLF6J9YP113FLQeCyB/bdJ/KVDS167w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "35bf7221-9008-4783-ab41-0f8e6a5b0cd7", new DateTime(2023, 12, 5, 23, 30, 52, 758, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 12, 5, 23, 30, 52, 758, DateTimeKind.Local).AddTicks(6225), "AQAAAAIAAYagAAAAEOufYN/BtBEnxGSeYSLtglbJ509OdoBoU8eKkiCv22g/YHk2Y/QghVIS/k9jDRDk8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7a8bfcdc-4211-4b9a-83e5-9036f5e4b37a", new DateTime(2023, 12, 5, 23, 30, 52, 677, DateTimeKind.Local).AddTicks(6419), new DateTime(2023, 12, 5, 23, 30, 52, 677, DateTimeKind.Local).AddTicks(6433), "AQAAAAIAAYagAAAAEJH8EvFgnFsxG3ojdFWNR12H+j7ALqkAi38oDx7xFPfZKBXnrS9lpu62NWbvbHq0dQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4315), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4331), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "IsRequired", "Name" },
                values: new object[] { 4, new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4350), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4350), null, false, true, "OS" });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4511), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4529), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4537), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4562), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4569), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4437), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4513), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4522), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4539), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4555), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4563), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4515), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4523), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4531), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4556), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4564), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4571), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4516), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4524), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4541), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4572), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4441), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4517), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4525), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4533), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4542), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4558), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4566), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4573), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4493), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4517), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4526), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4559), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4567), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4574), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4518), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4535), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4552), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4568), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4509), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4519), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4528), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4536), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4553), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4561), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4568), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4576), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4589), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4594), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4608), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4613), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4581), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4586), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4591), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4605), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4615), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4587), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4592), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4611), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4583), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4602), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4607), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4617), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4617) });
        }
    }
}
