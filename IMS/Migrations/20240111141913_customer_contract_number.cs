using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class customer_contract_number : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractDate",
                table: "ServerAllocations");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateContract",
                table: "Customers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "079cad21-a4ee-4af6-ab14-2c8ef39a02fe", new DateTime(2024, 1, 11, 21, 19, 12, 416, DateTimeKind.Local).AddTicks(6893), new DateTime(2024, 1, 11, 21, 19, 12, 416, DateTimeKind.Local).AddTicks(6905), new List<string>(), "AQAAAAIAAYagAAAAEGFPa8FjU9grDzb2Eh/QrYV/vB1W1GL8PLvz77ZCbDNcxiYaH2+60hVpbqqxkmmRlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a6a9d68f-b95b-4421-9bae-34d9aadf50ad", new DateTime(2024, 1, 11, 21, 19, 12, 499, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 1, 11, 21, 19, 12, 499, DateTimeKind.Local).AddTicks(7745), new List<string>(), "AQAAAAIAAYagAAAAEGclwXimZN1rNk6tqtbBYmC4DYC9CocYmbYEaTuXTQx5YTBR1ecZu8H4mZtm2jpSAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "bda5aeb9-f398-4602-9ab3-af7687ff673f", new DateTime(2024, 1, 11, 21, 19, 12, 346, DateTimeKind.Local).AddTicks(725), new DateTime(2024, 1, 11, 21, 19, 12, 346, DateTimeKind.Local).AddTicks(740), new List<string>(), "AQAAAAIAAYagAAAAEOysyAIOKhiETHeZ7WtAZdNLa2llKR5C2+x85MJXWsZZJK9VXwpw4vkWbhPEriZm/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "f3528c63-9d29-4a59-8afd-2c5132ce86e0", new DateTime(2024, 1, 11, 21, 19, 12, 276, DateTimeKind.Local).AddTicks(4297), new DateTime(2024, 1, 11, 21, 19, 12, 276, DateTimeKind.Local).AddTicks(4310), new List<string>(), "AQAAAAIAAYagAAAAEIX/lHvL6rKNXxqg6HpyVtUcCmPAuKJ+z3CyFgb2sj3RuT7LMEHKxZKYT1E8bFM5rg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6693), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6794), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6852), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6879), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6905), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6913), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6921), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6977), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6992), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6858), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6881), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6906), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6914), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6969), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6993), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6907), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6915), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6971), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6986), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6994), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6900), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6908), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6916), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6972), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6980), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6987), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6861), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6901), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6917), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6988), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6863), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6902), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6974), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6989), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6997), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6903), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6911), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6919), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6975), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6982), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6878), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6912), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6920), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6983), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7000), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7006), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7016), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7021), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7002), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7007), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7012), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7022), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7027), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7032), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7037), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7003), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7008), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7013), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7033), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7004), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7009), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7014), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7019), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7034), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7005), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7010), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7015), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7020), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7025), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7035), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7039), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7040) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateContract",
                table: "Customers");

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractDate",
                table: "ServerAllocations",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4836), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c6679df7-66d1-476a-8abb-58bb3362e18d", new DateTime(2024, 1, 11, 0, 1, 30, 21, DateTimeKind.Local).AddTicks(8344), new DateTime(2024, 1, 11, 0, 1, 30, 21, DateTimeKind.Local).AddTicks(8361), new List<string>(), "AQAAAAIAAYagAAAAELWI3XDTM+oOhE0kw4vD5yhGea1JgEhDGHi/AJKiXtN1o1IvuoF1ibC6BilVSm00zA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "da786a58-8c75-46c6-b35f-d52c8e674167", new DateTime(2024, 1, 11, 0, 1, 30, 121, DateTimeKind.Local).AddTicks(436), new DateTime(2024, 1, 11, 0, 1, 30, 121, DateTimeKind.Local).AddTicks(451), new List<string>(), "AQAAAAIAAYagAAAAELuypU0xSNas9Fv0ngtYm9CiLcYgUqRXDlObtlB5O0zWjQdWNYbb6uTFaUmxskRhZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "9b6b2316-10d1-4b78-9ad1-76735b0c1fbe", new DateTime(2024, 1, 11, 0, 1, 29, 938, DateTimeKind.Local).AddTicks(368), new DateTime(2024, 1, 11, 0, 1, 29, 938, DateTimeKind.Local).AddTicks(381), new List<string>(), "AQAAAAIAAYagAAAAEBFCHL+++4iatXalMNW+xyCQJ66CKiwSbkoaW2qSbjCukvQ1KFym65bKLgpGGB04QQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "808adc29-1286-4dec-834d-9a37e10591ff", new DateTime(2024, 1, 11, 0, 1, 29, 864, DateTimeKind.Local).AddTicks(1623), new DateTime(2024, 1, 11, 0, 1, 29, 864, DateTimeKind.Local).AddTicks(1638), new List<string>(), "AQAAAAIAAYagAAAAEF3UfdaU4S4lkn2J9DTv1BZzUe9XAbFYgqVE4TgPP4WY0ZxE/x47s1V4AAZ8pzDpzA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4867), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4896), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4913), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4921), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4985), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4847), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4889), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4898), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4906), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4914), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4922), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4978), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4848), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4890), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4899), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4923), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4979), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4849), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4891), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4900), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4908), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4988), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4892), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4901), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4909), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4917), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4981), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4893), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4902), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4910), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4918), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4982), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4990), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4894), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4903), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4927), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4983), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4991), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4895), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4904), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4976), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4984), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4992), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4994), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5000), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5005), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5010), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5015), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5020), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5030), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4996), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5001), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5006), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5011), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5016), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5021), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5026), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5031), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4997), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5002), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5007), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5012), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5017), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5022), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5027), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5032), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4998), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5003), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5008), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5013), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5018), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5023), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5028), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5033), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5004), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5009), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5014), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5019), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5024), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5029), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5034), new DateTime(2024, 1, 11, 0, 1, 29, 859, DateTimeKind.Local).AddTicks(5034) });
        }
    }
}
