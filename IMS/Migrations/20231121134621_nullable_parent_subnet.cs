using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class nullable_parent_subnet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentNetworkId",
                table: "IpSubnets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6183), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a53d014f-6dbd-41ec-833d-4085a24190a7", new DateTime(2023, 11, 21, 20, 46, 19, 893, DateTimeKind.Local).AddTicks(7827), new DateTime(2023, 11, 21, 20, 46, 19, 893, DateTimeKind.Local).AddTicks(7840), "AQAAAAIAAYagAAAAEGbH1wtySJBF28VoTC0Zl096ecJ/OGJGDYZ1BAHh8nFVHnEBGlD4/9IWGHSD42xlxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a90c7060-78d3-43f3-87b7-8e82f6cdde5c", new DateTime(2023, 11, 21, 20, 46, 19, 735, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 11, 21, 20, 46, 19, 735, DateTimeKind.Local).AddTicks(2509), "AQAAAAIAAYagAAAAEGYzSc3ZkD5PcgSOHObL7dB1g05lDoBZpgBjChvMIr30bxYywDSl5o/Y2PuTfR2Ydw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "5c95140f-090b-4f0f-923b-ce91355bfc65", new DateTime(2023, 11, 21, 20, 46, 19, 808, DateTimeKind.Local).AddTicks(4742), new DateTime(2023, 11, 21, 20, 46, 19, 808, DateTimeKind.Local).AddTicks(4757), "AQAAAAIAAYagAAAAEKIXIzs8fLShoDTEUk5ttI7jVUL4aaWG6tvErlCm/aM8js7OiEXj5OdNahIgXs89tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "fde01a94-b490-4916-a122-6da898bfced0", new DateTime(2023, 11, 21, 20, 46, 19, 649, DateTimeKind.Local).AddTicks(211), new DateTime(2023, 11, 21, 20, 46, 19, 649, DateTimeKind.Local).AddTicks(227), "AQAAAAIAAYagAAAAELuStNSApWkoA3Xs/mjJBywQ4O4J3reB94S5BPWjq/z31EYRDINme9pbHAfmspbi3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "59b120e6-ff9f-4d0d-947f-2de7891ac5bc", new DateTime(2023, 11, 21, 20, 46, 19, 570, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 11, 21, 20, 46, 19, 570, DateTimeKind.Local).AddTicks(5583), "AQAAAAIAAYagAAAAEEfC9g7DBvzgOGnVKNrfioiz1Fqe9EJlypnlbCNvpMQL0fRoLbNID9d70osSga3w1w==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(5942), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6119), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6142), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6151), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6127), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6201), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6225), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6234), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6217), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6227), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6235), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6252), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6218), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6208), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6229), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6246), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6307), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6209), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6220), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6247), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6211), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6221), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6231), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6309), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6232), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6249), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6214), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6223), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6233), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6241), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6311), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6332), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6337), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6347), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6322), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6318), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6339), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6329), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6340), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6336), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6357) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentNetworkId",
                table: "IpSubnets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7248), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "10302adc-9bc0-4cdc-9e32-3d3394f37c17", new DateTime(2023, 11, 20, 14, 27, 15, 177, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 11, 20, 14, 27, 15, 177, DateTimeKind.Local).AddTicks(9902), "AQAAAAIAAYagAAAAEIIS957XhTCyysn/QroYZTqHSXaRRRXCUoiHe4Xn/RQZIrqfYVcb5YdXsOVPE28vRQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2ba5fcb9-26f4-4824-a413-ea46cf482baf", new DateTime(2023, 11, 20, 14, 27, 15, 15, DateTimeKind.Local).AddTicks(7763), new DateTime(2023, 11, 20, 14, 27, 15, 15, DateTimeKind.Local).AddTicks(7776), "AQAAAAIAAYagAAAAEG/1EmJl4g4KMr2DnbulatwzRXCdlbQQOuWdFexmm24pFlBH+OMYfFgKCV667gKxgA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e604dc00-58d8-4f97-afa1-8d647af2b95e", new DateTime(2023, 11, 20, 14, 27, 15, 92, DateTimeKind.Local).AddTicks(9366), new DateTime(2023, 11, 20, 14, 27, 15, 92, DateTimeKind.Local).AddTicks(9377), "AQAAAAIAAYagAAAAEOq0MCcfBFb9BtnQXpNTn50affkD4L8BnF4uiL8IB4U5egrXEUkp6bW2Qtl9vG7usg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "21a86227-1882-4708-9d3e-9e59576787f1", new DateTime(2023, 11, 20, 14, 27, 14, 939, DateTimeKind.Local).AddTicks(1437), new DateTime(2023, 11, 20, 14, 27, 14, 939, DateTimeKind.Local).AddTicks(1449), "AQAAAAIAAYagAAAAEBRgQMh9BtcaXit0gfE/Qmfy8090yXlaIfw6XcU5f4wHRSp/SUzfPBpulc7ECVNELw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "396d47e1-549a-4167-828a-abb88209ff0b", new DateTime(2023, 11, 20, 14, 27, 14, 870, DateTimeKind.Local).AddTicks(5463), new DateTime(2023, 11, 20, 14, 27, 14, 870, DateTimeKind.Local).AddTicks(5469), "AQAAAAIAAYagAAAAEL2m/ag5m4XA8mlp9/ddRArPPVAQAdUJQ01ERyZ7F5tbr7+m3t0p+kBn9udMX6+pVg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(6956), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7051), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7067), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7079), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7091), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7112), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7131), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7144), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7169), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7182), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7157), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7254), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7292), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7362), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7371), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7379), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7387), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7283), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7293), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7347), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7364), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7372), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7285), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7294), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7348), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7356), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7365), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7373), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7381), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7286), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7295), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7374), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7382), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7390), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7287), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7296), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7350), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7358), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7367), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7375), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7391), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7359), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7368), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7384), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7290), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7298), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7352), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7377), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7393), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7291), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7299), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7353), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7361), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7395), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7402), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7407), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7417), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7422), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7469), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7398), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7408), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7413), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7418), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7470), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7399), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7404), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7409), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7414), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7424), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7400), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7425), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7467), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7472), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7401), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7406), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7411), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7421), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7468), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7473), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7473) });
        }
    }
}
