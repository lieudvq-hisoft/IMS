using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_server_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DNS",
                table: "Servers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6657), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d67c0bee-5b14-46cb-a38e-da1b168d8394", "AQAAAAIAAYagAAAAEHhhl4yEg9dC0BS2rTjxPL9D/bNBfQl/WqRe6ZBLL2bgLC1tbb4SU1t4qtt5/iWLDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b01c2fb-860b-4b35-a3d7-45fb4566964b", "AQAAAAIAAYagAAAAEHvPxpUwoRDtZW/ewa8Y20yMaftUYLoGk7xC2kJjgRMNM5BX4y76wpuPMY6clFxSzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5af17958-0e78-48ca-b5ba-a4b58596f5b2", "AQAAAAIAAYagAAAAEI1oEHkN6MRJ4LECFhl1aDcxkhxRfOTR4QNdnTSbFq8XhJAwDMxX+2bBcg6k/DevgA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a70e911a-ec42-4db3-b3d7-fccf5984bf1f", "AQAAAAIAAYagAAAAEDyVklwD+c4hkXZSbaTzPr/q+5NCC32G9/V7up5e9WITFLH4rhTniD2FSXpTfm9KqQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(345), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Status" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6462), 1 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7663), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6672), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6724), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6765), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6895), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6935), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7114), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7153), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6683), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6771), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6901), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6940), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7119), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7158), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6688), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7123), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7163), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6781), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6911), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7039), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7128), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7168), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6699), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6746), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6786), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6916), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7044), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7132), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7173), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6751), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6791), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6921), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7049), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7137), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7178), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6715), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6926), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7054), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7142), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7184), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6719), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6850), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6889), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7107), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7147), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7189), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7195), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7222), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7292), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7342), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7365), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7631), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7203), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7321), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7346), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7636), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7207), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7279), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7302), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7326), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7375), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7640), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7212), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7284), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7307), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7621), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7644), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7217), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7311), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7336), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7384), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7626), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7649), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(520), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(531), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(539), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(540) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DNS",
                table: "Servers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59846580-963e-4079-865f-36f70323d175", "AQAAAAIAAYagAAAAEE+wBwF5z9vPAjOp3FHlFSRdJ45D+GM8YuN1TmABMBkO+XWsfWo1K9+PnEz8gmaVLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9d16509-6beb-43d2-a3a6-af943aded8ff", "AQAAAAIAAYagAAAAEEALZGxH8T4jb9xiCd7cnslNQgjOzOzpCqXlXWUPURbjFo+SL6ayce6/0eWI8yAKGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06d8dbb8-2c75-4449-9323-91534bc13859", "AQAAAAIAAYagAAAAEIASPAZnDH95B6bJO2fYUaS37wFyqlCCzvMAaKQ8BDUJJO3hD7YND/PclNQrMuMZqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fcc9d238-370d-4648-9158-0d4084911012", "AQAAAAIAAYagAAAAEHoJJ3VDBfU6NMhr8I76fBK0rGBI5/5JLmrsSCyIYAhnqXzQ6xjQ8cnFTCM27IhepA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7339), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7396), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Status" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(327), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(330), 0 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1238), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(408), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(511), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(537), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(562), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(620), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(646), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(809), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(868), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(515), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(624), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(786), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(812), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(871), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(543), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(568), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(627), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(790), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(816), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(874), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(571), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(630), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(793), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(819), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(878), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(574), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(633), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(796), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(822), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(577), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(636), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(799), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(826), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(884), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(530), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(556), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(614), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(639), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(802), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(861), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(888), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(617), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(642), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(806), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(865), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(913), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(929), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(978), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(994), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1010), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1026), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1178), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(900), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(916), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(933), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(981), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1013), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1165), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1182), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(903), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(920), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(936), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(984), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1000), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1169), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1185), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(906), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(923), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(970), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(987), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1003), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1020), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1172), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1188), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(910), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(926), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(974), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(990), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1006), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1023), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1175), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7439), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7451), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7460) });
        }
    }
}
