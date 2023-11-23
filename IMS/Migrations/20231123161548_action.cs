using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class action : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Action",
                table: "RequestUpgradeUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Action",
                table: "RequestExpandUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Action",
                table: "AppointmentUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8895), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "59a0567f-5b7d-48ce-aa33-26525a50c0e7", new DateTime(2023, 11, 23, 23, 15, 47, 349, DateTimeKind.Local).AddTicks(6179), new DateTime(2023, 11, 23, 23, 15, 47, 349, DateTimeKind.Local).AddTicks(6192), "AQAAAAIAAYagAAAAEFHf7ZdlKBj46KmEd2TVQDzdDXhZV1oQUGIv+5Y4+qpZHMi3qhXdOBkywHBE7aZuMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ea6f4c63-8291-4d8d-9572-3766fa1c2cf9", new DateTime(2023, 11, 23, 23, 15, 47, 172, DateTimeKind.Local).AddTicks(468), new DateTime(2023, 11, 23, 23, 15, 47, 172, DateTimeKind.Local).AddTicks(481), "AQAAAAIAAYagAAAAEDBk6Lbv60fgux9JAf+P8dDV+LS0k+8SLdBtpCP+baHIWWJna4RarckZiy7k1sJubQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "05e5b3df-d1d3-4411-b947-743acf48a587", new DateTime(2023, 11, 23, 23, 15, 47, 265, DateTimeKind.Local).AddTicks(7876), new DateTime(2023, 11, 23, 23, 15, 47, 265, DateTimeKind.Local).AddTicks(7890), "AQAAAAIAAYagAAAAEAxr5QFMkflRoF98lBebjJDJzsP0ajF4g3FCqfK5TRAFuSrt6nr3X8euO6zRIMBJSA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "5c67b731-5f83-401b-bffd-e7c6d9e667c3", new DateTime(2023, 11, 23, 23, 15, 47, 101, DateTimeKind.Local).AddTicks(4013), new DateTime(2023, 11, 23, 23, 15, 47, 101, DateTimeKind.Local).AddTicks(4027), "AQAAAAIAAYagAAAAEGKj7A1qvMO4SQytzUlCpZFAXJpLtJ3GdVRi0n4S5j/wrVUfd0adZKEXPxoVWst1Vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1b574038-81b5-45e0-85c7-99f95f380856", new DateTime(2023, 11, 23, 23, 15, 47, 32, DateTimeKind.Local).AddTicks(8251), new DateTime(2023, 11, 23, 23, 15, 47, 32, DateTimeKind.Local).AddTicks(8258), "AQAAAAIAAYagAAAAEJpRi72uRcHOX+dzuNyCXVmBF62+0w9ZZsWBan6H2GfrCs8cFRoTv2Rl/1NuDaV8yw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8489), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8662), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8677), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8734), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8774), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9009), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9017), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8967), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9011), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9019), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8925), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8944), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8968), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9020), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9013), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9021), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8928), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8946), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9014), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9022), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8947), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8955), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8963), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9015), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9023), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8964), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9008), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9016), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9024), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9032), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9043), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9047), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9052), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9057), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9062), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9028), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9034), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9043), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9053), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9058), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9063), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9044), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9054), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9059), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9064), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9041), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9050), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9055), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9060), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9065), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9031), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9036), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9041), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9046), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9051), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9056), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9061), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9066), new DateTime(2023, 11, 23, 23, 15, 47, 27, DateTimeKind.Local).AddTicks(9066) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "RequestUpgradeUsers");

            migrationBuilder.DropColumn(
                name: "Action",
                table: "RequestExpandUsers");

            migrationBuilder.DropColumn(
                name: "Action",
                table: "AppointmentUsers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2497), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "63b4c71a-5187-439b-9424-6fa40ff2cda8", new DateTime(2023, 11, 22, 22, 3, 53, 333, DateTimeKind.Local).AddTicks(9074), new DateTime(2023, 11, 22, 22, 3, 53, 333, DateTimeKind.Local).AddTicks(9087), "AQAAAAIAAYagAAAAEC0pMunZsdwbEzBG8XMeWl/NyhgR8txB46B0I/J6JDQdx7sELk6GUEGzrRyQKkvbFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9742a9cd-6f86-4eeb-bd87-a7f87452de4f", new DateTime(2023, 11, 22, 22, 3, 53, 72, DateTimeKind.Local).AddTicks(7646), new DateTime(2023, 11, 22, 22, 3, 53, 72, DateTimeKind.Local).AddTicks(7658), "AQAAAAIAAYagAAAAEOGJJPQNT/Yv1Sb9rwZpD4ms4q93aJEYAVF5cf3tUlEGwXiCiv8Z9q+mBtNXxb3Ong==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c5f3345f-3e77-4252-86fc-5a050706b55e", new DateTime(2023, 11, 22, 22, 3, 53, 218, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 11, 22, 22, 3, 53, 218, DateTimeKind.Local).AddTicks(2982), "AQAAAAIAAYagAAAAEJvTxZxBFl2Q4BbpIYGqBpYAnblbi7WfF8Oe5GuEKfr6VLJRGc2TlPZYX3iYyB3bLA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "219c5187-9345-4e40-9249-aed7f6f0e2d2", new DateTime(2023, 11, 22, 22, 3, 52, 975, DateTimeKind.Local).AddTicks(8257), new DateTime(2023, 11, 22, 22, 3, 52, 975, DateTimeKind.Local).AddTicks(8268), "AQAAAAIAAYagAAAAEGeZy4ov5RyaGW3DrVdHPflsDXg1oYAltpwGHW6Bzh3sFVWwza8uNYuKE3uIlXtfOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a1262b3c-ac7c-4873-813a-607473224704", new DateTime(2023, 11, 22, 22, 3, 52, 898, DateTimeKind.Local).AddTicks(2358), new DateTime(2023, 11, 22, 22, 3, 52, 898, DateTimeKind.Local).AddTicks(2362), "AQAAAAIAAYagAAAAEC/uvbbc1KkIE6n6xnWbL1M758kpuBXrtvYqTxLC7Ku8lTz8KEpF2FKvmaPfjKeeyQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2286), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2371), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2387), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2395), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2421), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2433), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2448), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2464), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2457), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2525), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2587), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2596), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2606), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2551), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2579), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2588), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2598), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2589), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2599), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2553), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2591), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2609), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2543), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2554), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2583), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2592), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2601), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2611), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2545), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2584), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2593), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2612), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2585), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2594), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2604), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2613), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2576), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2586), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2616), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2624), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2641), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2647), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2658), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2618), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2631), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2648), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2626), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2632), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2666), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2621), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2627), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2638), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2644), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2650), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2656), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2661), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2667), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2622), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2628), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2645), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2651), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2657), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2662), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2668), new DateTime(2023, 11, 22, 22, 3, 52, 895, DateTimeKind.Local).AddTicks(2668) });
        }
    }
}
