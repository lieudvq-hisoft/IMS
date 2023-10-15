using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class refactor_location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceLocations");

            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "Locations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsMoveout",
                table: "Locations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(2958), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebaadd40-4946-4549-b07b-a658008df3d7", "AQAAAAIAAYagAAAAEG/1wVofcnM0SJaSzgnNMXXMkBO97v5oS6CQ8zcNe6y5HmGrAHBK7w2LZ4z/IRrD9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26d563b9-c153-4413-9aab-e6dbefd79303", "AQAAAAIAAYagAAAAEA4DkolWQbGUocBTQiS7RRzHdcHAsV4hTPwPSPH0pJu9OjC1Pt9bnbqYPRmKX679/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd9b64e0-c93a-4472-8a01-dd5d26fe49f1", "AQAAAAIAAYagAAAAEIHoHOOIdfrX1Q412mvRf9DZTmF9oYlaVYucHH7RR0L33RKrLVkMOy8T68I9N+4vBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ea7f751-ed9d-48b9-8f17-2a8422e65c4e", "AQAAAAIAAYagAAAAECZOGfEOcLXJTG+0Qjp/w7353Tw4XqGYjjk5NsL1NjP0YbZlulcOTdrhhQEBkLyR4Q==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4202), new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4222), new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(2755), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "DeviceId", "IsMoveout" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5988), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5989), 1, false });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3369), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4060), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4429), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4562), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4699), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3115), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3394), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3648), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4079), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4220), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4445), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4579), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3411), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3664), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4734), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3177), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3428), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3680), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4110), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4254), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4478), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4752), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3558), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3706), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4126), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4361), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4771), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3223), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3580), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3723), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4143), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4381), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4510), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4647), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4789), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3597), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3738), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4159), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4397), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4528), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4665), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3255), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3613), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4412), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4545), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4681), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4885), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4901), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5402), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5679), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5793), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4928), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5006), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5189), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5702), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5809), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5903), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5023), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5103), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5244), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5719), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5825), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4960), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5038), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5277), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5612), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5734), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5944), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4975), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5135), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5324), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5776), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5961), new DateTime(2023, 10, 15, 11, 48, 20, 882, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4262), new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4271), new DateTime(2023, 10, 15, 11, 48, 20, 565, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DeviceId",
                table: "Locations",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Devices_DeviceId",
                table: "Locations",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Devices_DeviceId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_DeviceId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "IsMoveout",
                table: "Locations");

            migrationBuilder.CreateTable(
                name: "DeviceLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeviceId = table.Column<int>(type: "integer", nullable: false),
                    LocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsMoveout = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceLocations_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4558), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4942c0f5-b843-4960-990c-0bcb3e987468", "AQAAAAIAAYagAAAAEOx+lTzTleyIdADrrZfTDQWFX6VCQertWQVgqga3+4be78J1dAtxiKZHlr99eYlaLA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29ce73d6-13fd-4acb-9d9c-091731ca93b3", "AQAAAAIAAYagAAAAEIedclAbqb2iToAP5V4NvrzQK3Zf0pYoCX4LB3LyImYWSadV92yN/plKkBXUh3L1Ig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecea7c88-70ae-4560-80cc-c399320a87a0", "AQAAAAIAAYagAAAAEMWVE59l1pDig2IVrbpO3FTYza8cbPH6LdpQKv/VOcR8cC6dsqqxo2uE+HAcFbx1KQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa6d7270-3d5c-46a6-b16f-9d183f3d615a", "AQAAAAIAAYagAAAAEONZK8dYJYhmACpyDzo8PcoUf555BcCg474VcLuAwgH749zd30iA+NYke9BJqQssUw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 10, 15, 10, 23, 27, 502, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(6), new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.InsertData(
                table: "DeviceLocations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "IsMoveout", "LocationId" },
                values: new object[] { 1, new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6434), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6435), 1, false, false, 1 });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4489), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6404), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4628), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4845), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5071), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5361), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5588), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5782), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4668), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4861), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5372), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5467), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5794), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4873), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5384), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5479), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5713), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5805), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4704), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4885), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5109), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5396), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5623), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5724), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4718), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5120), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5502), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5634), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5736), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5829), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4740), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4930), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5319), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5646), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5038), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5337), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5565), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5658), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5759), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5349), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5442), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5576), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5678), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5914), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6078), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6133), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6229), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5982), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6144), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6100), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6194), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6359), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5950), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6110), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6370), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5961), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6121), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6218), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6272), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6381), new DateTime(2023, 10, 15, 10, 23, 27, 770, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(43), new DateTime(2023, 10, 15, 10, 23, 27, 503, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceLocations_DeviceId",
                table: "DeviceLocations",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceLocations_LocationId",
                table: "DeviceLocations",
                column: "LocationId");
        }
    }
}
