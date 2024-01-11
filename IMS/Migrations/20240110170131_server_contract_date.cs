using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class server_contract_date : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractDate",
                table: "ServerAllocations");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5490), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5509), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "2806c0d7-569f-4532-81c4-ce77e7d2c68f", new DateTime(2024, 1, 7, 13, 39, 45, 65, DateTimeKind.Local).AddTicks(865), new DateTime(2024, 1, 7, 13, 39, 45, 65, DateTimeKind.Local).AddTicks(880), new List<string>(), "AQAAAAIAAYagAAAAEFR4OqB06Lj5LfU44B9kjEDid6EmOeOTx+bkQWASUznlmS/wmKSJLFoJe9UJqE7tDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "936cab50-de2b-4e7f-b315-069a1cd94a2e", new DateTime(2024, 1, 7, 13, 39, 45, 154, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 1, 7, 13, 39, 45, 154, DateTimeKind.Local).AddTicks(6958), new List<string>(), "AQAAAAIAAYagAAAAENdEWBqsCB5oPu8c2FlsWXwiwaEwig7Aak72DIn//QGtt7Podf2jZ725p64PESqGPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7d43fb12-34ba-4788-8ee4-1f1511f75ac6", new DateTime(2024, 1, 7, 13, 39, 44, 978, DateTimeKind.Local).AddTicks(9901), new DateTime(2024, 1, 7, 13, 39, 44, 978, DateTimeKind.Local).AddTicks(9918), new List<string>(), "AQAAAAIAAYagAAAAEFocXL6/kMibifINJruyFuNlisenGbP+tUtwlKUkOoyuvJRCZ7OQGX/RWvNuJdTRog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a1ae7c68-8962-49a3-a755-bf18155767ec", new DateTime(2024, 1, 7, 13, 39, 44, 874, DateTimeKind.Local).AddTicks(4420), new DateTime(2024, 1, 7, 13, 39, 44, 874, DateTimeKind.Local).AddTicks(4426), new List<string>(), "AQAAAAIAAYagAAAAEJ5BSHVBdOTT4n64NcpiFXEa8v9oOMBPrIunv4hlBGqyxTSEObFpsDHv3GwfRC6VCg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5462), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5516), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5610), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5627), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5635), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5643), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5651), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5520), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5585), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5620), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5628), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5636), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5644), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5652), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5563), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5621), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5629), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5637), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5645), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5605), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5622), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5630), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5638), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5646), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5566), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5623), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5639), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5655), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5607), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5624), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5632), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5648), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5656), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5571), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5608), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5616), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5624), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5633), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5641), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5649), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5625), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5660), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5666), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5671), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5706), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5711), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5716), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5667), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5672), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5708), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5712), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5717), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5673), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5708), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5713), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5718), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5723), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5728), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5664), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5669), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5674), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5709), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5714), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5719), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5724), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5729), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5665), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5710), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5715), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5725), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5730) });
        }
    }
}
