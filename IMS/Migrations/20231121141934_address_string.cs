using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class address_string : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "IpAddresses",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4130), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4164), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "851e3323-af5c-4eca-809a-aa49c6fa82f9", new DateTime(2023, 11, 21, 21, 19, 32, 968, DateTimeKind.Local).AddTicks(598), new DateTime(2023, 11, 21, 21, 19, 32, 968, DateTimeKind.Local).AddTicks(615), "AQAAAAIAAYagAAAAEEBbeXO5gSJ9pwIZrXik+R3z7q5TsRuuOthD7WdF0OoX7/S7UGEy1XqGvn7KBSzfKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "92b1a83f-c24c-4908-aa21-ae1347e5b70e", new DateTime(2023, 11, 21, 21, 19, 32, 742, DateTimeKind.Local).AddTicks(4092), new DateTime(2023, 11, 21, 21, 19, 32, 742, DateTimeKind.Local).AddTicks(4108), "AQAAAAIAAYagAAAAECNfT2eBOp/hWUg2nE4V8+tT8aAraChhJwtdnnYy+B7OngNMGWS3GoSjX+IOAgjOjQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3479100a-9f56-47d6-aa9d-1b5dcee75307", new DateTime(2023, 11, 21, 21, 19, 32, 875, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 11, 21, 21, 19, 32, 875, DateTimeKind.Local).AddTicks(2210), "AQAAAAIAAYagAAAAEIOrcv3qt6TX0TYQuQFt3zF+0oitmHul4RKgF0elxxJC1UW8fRi5jp0Bghmzvl85wg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8e068c1b-447f-4c73-b953-b2c24333fa03", new DateTime(2023, 11, 21, 21, 19, 32, 651, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 11, 21, 21, 19, 32, 651, DateTimeKind.Local).AddTicks(1168), "AQAAAAIAAYagAAAAEG0Lj6qSzAM4whnSrobokBn5fK74LyOVDSVQT1WnA+fs/D7/4kqfHMAdnAQpq8FJ6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "40880607-26f8-4f34-9a4b-1204bf4badc6", new DateTime(2023, 11, 21, 21, 19, 32, 568, DateTimeKind.Local).AddTicks(3330), new DateTime(2023, 11, 21, 21, 19, 32, 568, DateTimeKind.Local).AddTicks(3342), "AQAAAAIAAYagAAAAEKrbrYiNkuKN1C+h5TBvRi/GFlDOXHDKcXbkRi8PT+fNOAJlhVb2JpVJRQT+U9LakQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3891), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3981), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4001), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4020), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4043), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4058), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4077), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4110), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4086), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4186), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4196), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4207), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4217), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4226), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4236), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4252), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4208), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4228), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4177), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4189), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4220), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4244), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4254), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4178), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4211), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4246), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4255), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4202), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4222), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4231), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4247), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4182), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4232), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4248), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4257), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4205), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4233), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4249), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4258), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4184), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4261), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4268), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4274), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4286), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4292), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4304), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4282), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4293), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4299), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4305), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4271), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4277), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4283), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4289), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4294), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4306), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4266), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4278), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4284), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4290), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4301), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4307), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4267), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4279), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4285), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4291), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4296), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4302), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4308), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4308) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Address",
                table: "IpAddresses",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1476), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "77e25688-5af2-44d8-b884-4d212aff8e84", new DateTime(2023, 11, 21, 20, 53, 17, 594, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 11, 21, 20, 53, 17, 594, DateTimeKind.Local).AddTicks(3921), "AQAAAAIAAYagAAAAEOJ2g5qwXCouIctf8SlrHKZmgyUa4wKZPJCf17dfNgRSDSmgtgFO0Vi3c89rVkuGqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3a2908ca-54d8-4e05-b6a2-3abf31c1761b", new DateTime(2023, 11, 21, 20, 53, 17, 316, DateTimeKind.Local).AddTicks(211), new DateTime(2023, 11, 21, 20, 53, 17, 316, DateTimeKind.Local).AddTicks(224), "AQAAAAIAAYagAAAAEBK4Wu12dxl/DjKHbJcaTQCT0JJypwLELMJA+FLoewy3EIOLa2mOg3kA+U81aG9bew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1738ea2e-6ea6-4e0f-869f-92a2aad6dc47", new DateTime(2023, 11, 21, 20, 53, 17, 387, DateTimeKind.Local).AddTicks(8030), new DateTime(2023, 11, 21, 20, 53, 17, 387, DateTimeKind.Local).AddTicks(8042), "AQAAAAIAAYagAAAAEJXCEuvwVly58bE52mELrNxEheewOUuFTBTko/fkw3f2mF6wvcoPGiuGEwYciDqrOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "18899372-41ec-43fe-afce-32fc565ea91f", new DateTime(2023, 11, 21, 20, 53, 17, 241, DateTimeKind.Local).AddTicks(784), new DateTime(2023, 11, 21, 20, 53, 17, 241, DateTimeKind.Local).AddTicks(796), "AQAAAAIAAYagAAAAEIivG/LzPlpIwsnE5OKG0l9iuvfS40jAiZbCu3ZSm4ZNM3yisn0QEpPB/CmWEzuNDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ed1d7b48-40b4-462a-b676-dd876eeb711c", new DateTime(2023, 11, 21, 20, 53, 17, 169, DateTimeKind.Local).AddTicks(9398), new DateTime(2023, 11, 21, 20, 53, 17, 169, DateTimeKind.Local).AddTicks(9405), "AQAAAAIAAYagAAAAEP4b0fgK1QZmoU29f7GN8p8MegCyoMxo6ar5bGaXN4GgmngiuLpmIG8+YwtmoZtJww==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1282), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1353), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1362), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1368), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1374), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1399), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1409), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1417), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1442), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1451), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1423), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1505), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1519), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1528), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1547), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1555), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1564), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1579), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1511), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1521), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1548), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1557), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1573), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1580), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1512), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1522), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1530), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1549), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1558), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1566), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1574), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1581), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1513), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1523), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1550), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1559), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1567), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1582), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1514), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1532), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1551), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1560), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1568), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1583), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1516), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1525), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1533), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1552), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1584), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1517), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1545), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1553), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1562), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1570), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1585), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1518), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1554), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1563), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1571), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1578), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1586), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1588), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1595), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1610), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1615), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1619), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1624), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1591), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1601), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1611), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1625), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1597), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1607), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1621), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1603), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1617), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1622), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1627), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1609), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1613), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1618), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1623), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1628), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1628) });
        }
    }
}
