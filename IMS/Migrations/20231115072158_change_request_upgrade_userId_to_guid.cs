using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_request_upgrade_userId_to_guid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "RequestUpgrades",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "becdee10-545c-4132-8153-c3080245a0d9", new DateTime(2023, 11, 15, 14, 21, 57, 859, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 11, 15, 14, 21, 57, 859, DateTimeKind.Local).AddTicks(5847), "AQAAAAIAAYagAAAAEBgnvZ4+lZGffDserNu1jGizozBFBEUeGzKnRLY/fmrEy0sBPycGp9a+GJDjffNbbA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6da09bc7-dedd-401c-bce8-1d9d26cfe577", new DateTime(2023, 11, 15, 14, 21, 57, 651, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 11, 15, 14, 21, 57, 651, DateTimeKind.Local).AddTicks(5053), "AQAAAAIAAYagAAAAEIEKn4sXd/fJ3u80Fth0y63gl9rzb6B5qB3OFcFhmwO0AuKl2qR4piH+2XnJ2p9Tyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "58230546-3d7a-4cda-97f7-fea9958e644c", new DateTime(2023, 11, 15, 14, 21, 57, 760, DateTimeKind.Local).AddTicks(5632), new DateTime(2023, 11, 15, 14, 21, 57, 760, DateTimeKind.Local).AddTicks(5643), "AQAAAAIAAYagAAAAEFTePy7TnJeU+zx8MQTSQ02MLI1n0AecZaQqUwo44dE3TwxjH52iy0HU4BwM4i958w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3987bd22-9d63-4f4d-81d1-0ccd23200846", new DateTime(2023, 11, 15, 14, 21, 57, 553, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 11, 15, 14, 21, 57, 553, DateTimeKind.Local).AddTicks(6319), "AQAAAAIAAYagAAAAEKez0Rrhj3gQifzfgUAOTfezRTOC2NsDLq9NS5622mpm//6U+sLfjDnbHbTe7i2JNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "165b4a62-f0ef-4ef9-938c-1a5d6ceb2a72", new DateTime(2023, 11, 15, 14, 21, 57, 464, DateTimeKind.Local).AddTicks(4057), new DateTime(2023, 11, 15, 14, 21, 57, 464, DateTimeKind.Local).AddTicks(4064), "AQAAAAIAAYagAAAAENVuDYr9qfWFta1Lg6oGyTtzfWTNObBASUHphb84D1+SBrTv1RvWeKDScUGLCK945w==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3605), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3725), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3737), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3750), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3772), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3800), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3829), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3868), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3842), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3914), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3984), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4003), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4012), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4022), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4030), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4038), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3919), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3986), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3996), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4014), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4023), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4031), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4039), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3975), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4005), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4015), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4040), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3988), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3998), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4006), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4016), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4025), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4041), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3978), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3989), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3999), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4007), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4017), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4034), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4042), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4000), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4009), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4018), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4027), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4035), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4043), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4001), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4010), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4019), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4036), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4044), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3993), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4002), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4021), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4029), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4045), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4047), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4094), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4104), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4108), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4113), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4119), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4105), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4109), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4114), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4120), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4050), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4106), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4110), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4115), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4121), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4091), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4096), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4102), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4106), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4111), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4117), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4121), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4052), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4092), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4097), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4102), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4107), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4112), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4117), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4122), new DateTime(2023, 11, 15, 14, 21, 57, 459, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpgrades_UserId",
                table: "RequestUpgrades",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestUpgrades_AspNetUsers_UserId",
                table: "RequestUpgrades",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestUpgrades_AspNetUsers_UserId",
                table: "RequestUpgrades");

            migrationBuilder.DropIndex(
                name: "IX_RequestUpgrades_UserId",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RequestUpgrades");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "89a5daa5-79a0-4671-8508-6d3511ae8ca4", new DateTime(2023, 11, 15, 14, 20, 19, 358, DateTimeKind.Local).AddTicks(8088), new DateTime(2023, 11, 15, 14, 20, 19, 358, DateTimeKind.Local).AddTicks(8099), "AQAAAAIAAYagAAAAEJRgWqem8K+qQekUFh+MVkTRFV4c13+SfuDtevK4UY4I1dfKA6hNkOFCP0sIR3VjCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4a691283-9ce5-43e8-bce8-cb4fb68c92e0", new DateTime(2023, 11, 15, 14, 20, 19, 188, DateTimeKind.Local).AddTicks(8423), new DateTime(2023, 11, 15, 14, 20, 19, 188, DateTimeKind.Local).AddTicks(8438), "AQAAAAIAAYagAAAAEJQG3jSeJHYzILhwSvwcbRNxN82tsYl/eI/0imlTTNjOPEFoVlVOKdusa1mIyzB+vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8ca04274-dc2d-4d3d-a035-327acd413b6a", new DateTime(2023, 11, 15, 14, 20, 19, 275, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 11, 15, 14, 20, 19, 275, DateTimeKind.Local).AddTicks(2547), "AQAAAAIAAYagAAAAENtG1qziskXhkRW7X1cZ2S1NcN00GycvMP1PVSeubVTkr+eU0FCC2VYHEtM8OUwMTg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0c803d3c-9f58-4041-8910-713ea4b4fa7b", new DateTime(2023, 11, 15, 14, 20, 19, 101, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 11, 15, 14, 20, 19, 101, DateTimeKind.Local).AddTicks(8090), "AQAAAAIAAYagAAAAEOeBqANSza3vRjG0lcrdWnrPJ4U9uRdkCk0alNwZ8b7tuF531vFGgzF0iNFNVLrvkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b417743f-078d-4759-b435-7a48cdd9f9c1", new DateTime(2023, 11, 15, 14, 20, 19, 32, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 11, 15, 14, 20, 19, 32, DateTimeKind.Local).AddTicks(8133), "AQAAAAIAAYagAAAAEIsffABIDkEcSnDS9RgX8urV+QMtzVW79ZKrBuLlPvw8OmSn1ByUC5zC+V5MM6JaWg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1816), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1986), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2001), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2013), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2038), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2088), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2127), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2175), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2217), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2226), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2234), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2275), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2283), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2291), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2209), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2219), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2227), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2236), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2220), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2237), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2293), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2212), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2221), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2229), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2238), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2286), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2213), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2222), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2204), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2214), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2223), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2231), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2240), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2288), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2296), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2205), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2215), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2224), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2232), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2281), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2206), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2225), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2233), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2300), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2317), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2327), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2332), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2337), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2308), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2313), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2323), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2328), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2333), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2309), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2319), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2324), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2329), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2339), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2320), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2335), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2311), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2336), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2342) });
        }
    }
}
