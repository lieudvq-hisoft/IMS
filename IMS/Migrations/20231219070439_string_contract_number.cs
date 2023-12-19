using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class string_contract_number : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContractNumber",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3590), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "ab29bce3-0be2-40c4-a00f-9e0dbebd4f2c", new DateTime(2023, 12, 19, 14, 4, 38, 850, DateTimeKind.Local).AddTicks(2484), new DateTime(2023, 12, 19, 14, 4, 38, 850, DateTimeKind.Local).AddTicks(2499), new List<string>(), "AQAAAAIAAYagAAAAEGnPJPpNXnkytSEf43Wc89ZgzeH7gAmlQ25N/2FZLpGjMHAw8SLO46CDpa8g1wxx8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "1c83e79e-9eba-4845-84eb-332c02065cec", new DateTime(2023, 12, 19, 14, 4, 38, 931, DateTimeKind.Local).AddTicks(6964), new DateTime(2023, 12, 19, 14, 4, 38, 931, DateTimeKind.Local).AddTicks(6976), new List<string>(), "AQAAAAIAAYagAAAAEIJo1VFGh60G05vQOpgbIjaTpHu21PKW3EluAwc7ABC2fvBfTAssISzxBlYqYA/dmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "496d4788-72bb-4ef7-9feb-a411e0bc110b", new DateTime(2023, 12, 19, 14, 4, 38, 775, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 12, 19, 14, 4, 38, 775, DateTimeKind.Local).AddTicks(7363), new List<string>(), "AQAAAAIAAYagAAAAENQNL+rf1u3XMDxB/8MgaG3HmV/j6KOgXzpBQPRjAb6qTo9heCphK817ZjdiTyzb7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7b8cda70-7690-42a1-817a-05b804c4bc8a", new DateTime(2023, 12, 19, 14, 4, 38, 696, DateTimeKind.Local).AddTicks(9353), new DateTime(2023, 12, 19, 14, 4, 38, 696, DateTimeKind.Local).AddTicks(9365), new List<string>(), "AQAAAAIAAYagAAAAEHqwHcjalFM+Ij2euW77KlHcRT/MuYs8jgTsBuCcoV22wO1SjKxL/QN/KGqLGoaH1w==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3330), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3520), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3537), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3550), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3563), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3655), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3665), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3674), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3723), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3731), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3739), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3747), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3620), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3657), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3667), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3676), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3725), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3732), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3740), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3748), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3659), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3668), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3677), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3726), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3733), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3741), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3749), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3660), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3678), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3727), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3734), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3742), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3750), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3661), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3670), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3679), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3728), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3735), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3743), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3662), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3671), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3719), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3729), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3736), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3744), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3636), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3672), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3721), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3730), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3737), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3745), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3637), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3664), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3673), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3722), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3730), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3738), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3746), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3753), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3755), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3762), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3767), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3772), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3777), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3782), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3786), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3791), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3763), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3773), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3778), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3783), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3787), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3792), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3759), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3764), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3774), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3779), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3784), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3788), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3793), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3760), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3765), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3770), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3775), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3780), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3784), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3789), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3794), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3766), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3776), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3781), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3785), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3790), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3795), new DateTime(2023, 12, 19, 14, 4, 38, 691, DateTimeKind.Local).AddTicks(3795) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContractNumber",
                table: "Customers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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
    }
}
