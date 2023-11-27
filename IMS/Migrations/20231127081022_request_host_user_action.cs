using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_host_user_action : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "RequestHostUsers",
                newName: "Action");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "30a44537-98b2-4f3c-a203-9f58949aedca", new DateTime(2023, 11, 27, 15, 10, 22, 69, DateTimeKind.Local).AddTicks(905), new DateTime(2023, 11, 27, 15, 10, 22, 69, DateTimeKind.Local).AddTicks(917), "AQAAAAIAAYagAAAAECCYyshO3gwuREUBzEucX6aSFE5kqaDZXNCB2/M/xjbsljB1YNHLIfzBD4aQ5pxhzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c40bb087-f12a-4384-b272-98d689eca407", new DateTime(2023, 11, 27, 15, 10, 21, 921, DateTimeKind.Local).AddTicks(330), new DateTime(2023, 11, 27, 15, 10, 21, 921, DateTimeKind.Local).AddTicks(343), "AQAAAAIAAYagAAAAEI6BIQ1MFcPX1tiGeOQViGhJuLS5yihSgqQBNiYbVrd+BJNpy/QPmIqdwCmwAuNQGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c054a28e-db7f-4cff-b24a-563ead9c4a71", new DateTime(2023, 11, 27, 15, 10, 21, 999, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 11, 27, 15, 10, 21, 999, DateTimeKind.Local).AddTicks(880), "AQAAAAIAAYagAAAAENGNEIVn5nJkAM4aOdOC+9LBq6xd9Kff1pHBT87b6kf6gDD3CkNi8AKIKxHuPe4Vcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "db39c13c-3bcb-4f53-b295-01eab83619ad", new DateTime(2023, 11, 27, 15, 10, 21, 776, DateTimeKind.Local).AddTicks(1477), new DateTime(2023, 11, 27, 15, 10, 21, 776, DateTimeKind.Local).AddTicks(1491), "AQAAAAIAAYagAAAAEKhC+sfKGXkRvsRQNYJPEGFEn0Zp3LOyEy19MDfbS2kkYA++x7WE4VYWqlpSAgD+4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "00628366-998c-4b0e-9c77-3e681312076c", new DateTime(2023, 11, 27, 15, 10, 21, 679, DateTimeKind.Local).AddTicks(1978), new DateTime(2023, 11, 27, 15, 10, 21, 679, DateTimeKind.Local).AddTicks(1990), "AQAAAAIAAYagAAAAEOMaHauVFXOHFr2Rt4Zn2NGjxYWDph3I0qLRV7LV5a2Y8+qnuDUiRKHksG0/RkfJ6A==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8509), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8525), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8574), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8592), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8657), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8701), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8673), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8757), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8813), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8822), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8838), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8778), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8816), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8824), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8817), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8826), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8835), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8812), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8821), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8829), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8914), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8919), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8925), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8916), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8921), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8941), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8912), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8917), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8927), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8907), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8913), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8923), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8928), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 11, 27, 15, 10, 21, 673, DateTimeKind.Local).AddTicks(8944) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Action",
                table: "RequestHostUsers",
                newName: "Type");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2137), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bd667b00-9527-42cf-babf-bab71c6b63e8", new DateTime(2023, 11, 26, 13, 41, 8, 814, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 11, 26, 13, 41, 8, 814, DateTimeKind.Local).AddTicks(3264), "AQAAAAIAAYagAAAAEJLRqQ/+9oldZI4v8Ox9e2AaG7w/DO+8JfUjcKVfvaeuWlT6zXjnYaLgH9iHzqfK5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e70b09c1-a1f8-4fce-b656-317960f74ca9", new DateTime(2023, 11, 26, 13, 41, 8, 653, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 11, 26, 13, 41, 8, 653, DateTimeKind.Local).AddTicks(3104), "AQAAAAIAAYagAAAAEPaUqLlvS6HTKjyGKRwSYyt0yVcBcDS5YtoRj4198qHm/cF301vuN6GvLsNm27yHXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "35ef73cf-9e93-4df6-834c-9a300d45e671", new DateTime(2023, 11, 26, 13, 41, 8, 721, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 11, 26, 13, 41, 8, 721, DateTimeKind.Local).AddTicks(3324), "AQAAAAIAAYagAAAAEDxb9lS6xPIolGjaTQ1SSsym4NTVSHiogygkx0LIu5AGFueAenUaZo48AQeQeE6/Vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b0a0859e-1f49-4d0d-b538-b9b41dead30b", new DateTime(2023, 11, 26, 13, 41, 8, 518, DateTimeKind.Local).AddTicks(8160), new DateTime(2023, 11, 26, 13, 41, 8, 518, DateTimeKind.Local).AddTicks(8175), "AQAAAAIAAYagAAAAECPULR/zVz7X8bkQ+MVWarKYkoaNgs4Zkynx09Xi4ahRnIz8MOGVdz3ZhM9acvlfmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "aad610c9-de0e-4429-a913-1439d9d87e82", new DateTime(2023, 11, 26, 13, 41, 8, 366, DateTimeKind.Local).AddTicks(8299), new DateTime(2023, 11, 26, 13, 41, 8, 366, DateTimeKind.Local).AddTicks(8309), "AQAAAAIAAYagAAAAEMruiAjEVOUgmUv4YnJV6uYvBxdtjW4LvEbbffa39OeJbiFP9WEFq6hb+uCietPUUg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1845), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1927), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1944), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1954), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1962), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1982), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1996), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2006), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2028), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2040), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2015), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2154), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2162), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2171), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2187), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2155), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2164), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2172), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2188), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2203), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2147), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2165), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2173), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2204), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2148), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2182), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2197), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2205), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2149), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2175), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2183), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2190), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2198), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2206), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2151), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2168), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2184), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2191), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2169), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2177), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2208), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2153), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2178), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2186), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2193), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2209), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2263), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2283), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2212), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2264), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2269), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2274), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2288), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2293), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2213), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2265), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2275), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2214), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2266), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2281), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2262), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2267), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2272), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2286), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2291), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2296), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2296) });
        }
    }
}
