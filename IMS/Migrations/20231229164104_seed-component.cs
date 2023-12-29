using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class seedcomponent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "RequireCapacity",
                table: "Components");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6582), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c9fc4e71-0c4a-4817-b4a4-4aea30aee8bf", new DateTime(2023, 12, 29, 23, 41, 1, 178, DateTimeKind.Local).AddTicks(7151), new DateTime(2023, 12, 29, 23, 41, 1, 178, DateTimeKind.Local).AddTicks(7169), new List<string>(), "AQAAAAIAAYagAAAAEAs8ouxvXugAILVoSLOtEtAoEU2BONw8FiQe03HfxuR5G+w8FDYkZI4iLBVxJw0Tag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "6c6e6343-3b97-46f0-a703-0a984a77d329", new DateTime(2023, 12, 29, 23, 41, 1, 325, DateTimeKind.Local).AddTicks(8901), new DateTime(2023, 12, 29, 23, 41, 1, 325, DateTimeKind.Local).AddTicks(8918), new List<string>(), "AQAAAAIAAYagAAAAEJlh6ojiKVxbDNn6+nOwtCfuxdlHhUA9SV/hWCYZZ4Jd56ZI5/QXprR0OOVqfUigbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a108cd19-ecde-4a8e-bb91-f74248c7b382", new DateTime(2023, 12, 29, 23, 41, 1, 50, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 12, 29, 23, 41, 1, 50, DateTimeKind.Local).AddTicks(2940), new List<string>(), "AQAAAAIAAYagAAAAEJJOcSX1+fXUieRMXp9vu/1x/Z0jNpO4HF/+uh70nxsB7FAbdla258VZwI6fFnZmpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "2e3e1ed4-2c8e-4b01-bd2e-276dcbc4e22b", new DateTime(2023, 12, 29, 23, 41, 0, 930, DateTimeKind.Local).AddTicks(87), new DateTime(2023, 12, 29, 23, 41, 0, 930, DateTimeKind.Local).AddTicks(103), new List<string>(), "AQAAAAIAAYagAAAAEIZsvwTcvaNJDxvE8oi9sZnYLoBHEqNa1HCqcUEeXPDzE+HFUNQ9W/RgDnxMhAS8Zw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6389), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6401), false });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6541), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6542), "RAM" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired", "Name" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6551), false, "Harddisk" });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6643), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6651), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6668), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6592), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6636), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6653), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6661), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6669), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6593), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6638), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6645), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6654), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6662), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6712), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6595), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6638), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6663), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6713), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6595), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6639), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6656), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6664), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6671), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6598), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6631), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6657), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6665), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6672), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6715), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6641), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6649), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6666), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6673), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6601), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6633), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6642), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6650), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6659), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6667), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6708), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6717), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6718), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6752), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6721), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6727), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6732), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6737), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6742), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6748), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6753), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6758), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6722), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6728), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6733), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6738), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6743), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6759), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6723), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6734), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6739), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6744), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6755), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6724), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6735), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6745), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6751), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 12, 29, 23, 41, 0, 924, DateTimeKind.Local).AddTicks(6762) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RequireCapacity",
                table: "Components",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7453), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7465), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "1a8a6907-04f2-48e1-a898-106ad5a66fa3", new DateTime(2023, 12, 29, 17, 53, 4, 847, DateTimeKind.Local).AddTicks(9145), new DateTime(2023, 12, 29, 17, 53, 4, 847, DateTimeKind.Local).AddTicks(9157), new List<string>(), "AQAAAAIAAYagAAAAEHLlkn1HyXukwug8eMBQuC1t0rMCNq7IzLMEFvfeYDvRdnkBF0bpGfng6slYhf/eVw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "f54a2877-0b0f-4c0e-86c5-e8b27c7daebb", new DateTime(2023, 12, 29, 17, 53, 4, 938, DateTimeKind.Local).AddTicks(2812), new DateTime(2023, 12, 29, 17, 53, 4, 938, DateTimeKind.Local).AddTicks(2826), new List<string>(), "AQAAAAIAAYagAAAAEJUmZY5V6hYD+tCiItT35bZD89azI9CCI3/GSfwKb4Mj3c3oFdhs6Gh+0ykWcaFonw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "e03ece53-bec5-4fde-94fd-e0ad926583b8", new DateTime(2023, 12, 29, 17, 53, 4, 749, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 12, 29, 17, 53, 4, 749, DateTimeKind.Local).AddTicks(9568), new List<string>(), "AQAAAAIAAYagAAAAEN+ucUid4PWNlF3QqLRVnV+JrpdiDw8QmElJOyCunYQcncBaRPUfD23nlMNi8CjeDg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7d3b3826-b119-42b1-b6d7-afe6c87c7655", new DateTime(2023, 12, 29, 17, 53, 4, 654, DateTimeKind.Local).AddTicks(4301), new DateTime(2023, 12, 29, 17, 53, 4, 654, DateTimeKind.Local).AddTicks(4314), new List<string>(), "AQAAAAIAAYagAAAAECxBE6dCeRsfWkXkYxvIlYEHQbEiwmXm16X90Ukkemc3G7IdpE2i0P3O20QgmdZuVg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired", "RequireCapacity" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7238), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7253), true, false });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name", "RequireCapacity" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7406), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7407), "GPU", true });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired", "Name", "RequireCapacity" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7415), true, "RAM", true });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "IsRequired", "Name", "RequireCapacity" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7422), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7423), null, false, false, "Motherboard", false },
                    { 5, new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7430), null, false, true, "Harddisk", true }
                });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7520), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7529), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7536), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7545), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7596), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7476), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7512), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7522), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7530), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7538), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7589), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7513), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7523), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7531), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7598), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7605), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7479), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7524), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7540), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7591), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7599), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7606), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7516), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7525), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7533), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7541), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7592), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7607), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7517), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7526), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7533), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7542), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7593), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7608), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7491), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7518), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7527), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7534), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7543), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7594), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7601), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7609), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7509), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7528), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7535), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7544), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7595), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7602), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7619), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7629), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7634), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7639), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7644), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7649), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7614), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7625), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7630), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7640), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7645), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7616), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7621), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7626), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7631), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7636), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7641), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7646), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7617), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7622), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7627), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7632), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7637), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7642), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7647), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7652), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7618), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7623), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7628), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7638), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7643), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7648), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 12, 29, 17, 53, 4, 650, DateTimeKind.Local).AddTicks(7653) });
        }
    }
}
