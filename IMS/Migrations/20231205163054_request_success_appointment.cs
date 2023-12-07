using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_success_appointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RemovalDateCreated",
                table: "RequestExpands",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemovalDateUpdated",
                table: "RequestExpands",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SuccessExpandAppointmentId",
                table: "RequestExpands",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4425), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "562d9048-8730-4c01-80f5-c3d1e90e0cc0", new DateTime(2023, 12, 5, 23, 30, 52, 971, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 12, 5, 23, 30, 52, 971, DateTimeKind.Local).AddTicks(5210), "AQAAAAIAAYagAAAAEBUNLxK5bq36z7aaP9uwcTGWvXXhFgNTX9t8ACpyaSAvtnI6UzlWDc6Q3ugLg+zaow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8921e5fa-50d2-404f-aebd-15f0cc4ed7f1", new DateTime(2023, 12, 5, 23, 30, 52, 832, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 12, 5, 23, 30, 52, 832, DateTimeKind.Local).AddTicks(4615), "AQAAAAIAAYagAAAAEMaSl0AFCDFXAIODU4PwqZPGCmU0Jq3GUMrBQgWbwiXaQ8sckqRtZk83RWS0Q4fzmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "51c746bf-9f52-46b1-b119-6db642fc332a", new DateTime(2023, 12, 5, 23, 30, 52, 902, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 12, 5, 23, 30, 52, 902, DateTimeKind.Local).AddTicks(4063), "AQAAAAIAAYagAAAAEC9vFzD8OJPNQddjqvC7jPiRb1kvHB31JlmfLF6J9YP113FLQeCyB/bdJ/KVDS167w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "35bf7221-9008-4783-ab41-0f8e6a5b0cd7", new DateTime(2023, 12, 5, 23, 30, 52, 758, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 12, 5, 23, 30, 52, 758, DateTimeKind.Local).AddTicks(6225), "AQAAAAIAAYagAAAAEOufYN/BtBEnxGSeYSLtglbJ509OdoBoU8eKkiCv22g/YHk2Y/QghVIS/k9jDRDk8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7a8bfcdc-4211-4b9a-83e5-9036f5e4b37a", new DateTime(2023, 12, 5, 23, 30, 52, 677, DateTimeKind.Local).AddTicks(6419), new DateTime(2023, 12, 5, 23, 30, 52, 677, DateTimeKind.Local).AddTicks(6433), "AQAAAAIAAYagAAAAEJH8EvFgnFsxG3ojdFWNR12H+j7ALqkAi38oDx7xFPfZKBXnrS9lpu62NWbvbHq0dQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4315), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4331), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4350), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4511), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4529), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4537), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4562), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4569), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4437), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4513), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4522), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4539), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4555), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4563), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4515), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4523), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4531), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4556), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4564), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4571), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4516), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4524), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4541), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4572), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4441), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4517), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4525), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4533), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4542), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4558), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4566), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4573), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4493), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4517), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4526), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4559), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4567), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4574), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4518), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4535), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4552), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4568), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4509), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4519), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4528), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4536), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4553), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4561), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4568), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4576), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4589), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4594), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4608), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4613), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4581), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4586), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4591), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4605), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4615), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4587), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4592), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4611), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4583), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4602), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4607), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4617), new DateTime(2023, 12, 5, 23, 30, 52, 672, DateTimeKind.Local).AddTicks(4617) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemovalDateCreated",
                table: "RequestExpands");

            migrationBuilder.DropColumn(
                name: "RemovalDateUpdated",
                table: "RequestExpands");

            migrationBuilder.DropColumn(
                name: "SuccessExpandAppointmentId",
                table: "RequestExpands");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3280), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f655f15a-c30c-410f-a2a8-1be9b992a5c6", new DateTime(2023, 12, 5, 22, 1, 41, 530, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 12, 5, 22, 1, 41, 530, DateTimeKind.Local).AddTicks(4110), "AQAAAAIAAYagAAAAEPV0Op4AF21MihvyQQLwJsIlV/MlhCb35soZbboye6jn2pCv8p7EUj4SiV5KzLWZhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "465c46f9-eac0-4a93-b5f3-c413648a7d01", new DateTime(2023, 12, 5, 22, 1, 41, 388, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 12, 5, 22, 1, 41, 388, DateTimeKind.Local).AddTicks(1147), "AQAAAAIAAYagAAAAEByWpisVMAFz1gbmPCqDCAEmup7GnO5tP9M2MptkoOsg0lRDlZLeTUVe63NzAE/TXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "dcc357a1-c2c2-4cd7-8a76-170f74c75228", new DateTime(2023, 12, 5, 22, 1, 41, 460, DateTimeKind.Local).AddTicks(988), new DateTime(2023, 12, 5, 22, 1, 41, 460, DateTimeKind.Local).AddTicks(1000), "AQAAAAIAAYagAAAAEAK+pwL7VMkh1KKnblnuKuuDcpE0f0xxDdHgjkh2otLnDY+tvMXpRpI06s2Y+X9nPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f0e7afab-b79d-4b05-8944-83dffd3ec671", new DateTime(2023, 12, 5, 22, 1, 41, 320, DateTimeKind.Local).AddTicks(2093), new DateTime(2023, 12, 5, 22, 1, 41, 320, DateTimeKind.Local).AddTicks(2106), "AQAAAAIAAYagAAAAEL6zLAtVxk38dw3okboIlrA23f3lWr05kl0OTb6MCuWSu17yDHLPijnl0rd0/Fhrpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "cd558532-6df2-4287-9459-f4d2f81f1c47", new DateTime(2023, 12, 5, 22, 1, 41, 252, DateTimeKind.Local).AddTicks(6179), new DateTime(2023, 12, 5, 22, 1, 41, 252, DateTimeKind.Local).AddTicks(6182), "AQAAAAIAAYagAAAAEJAGJsmpjXV3jIXsbcdqwjoAu6dSdFWmwaWJtnE1YkNjGxZW13hDsMIg7hu5QsCgkA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3305), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3334), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3343), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3398), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3406), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3415), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3423), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3431), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3310), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3336), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3345), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3399), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3408), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3416), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3337), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3391), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3400), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3409), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3433), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3338), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3393), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3401), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3410), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3418), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3426), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3434), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3319), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3339), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3394), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3402), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3411), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3427), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3321), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3340), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3395), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3403), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3412), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3428), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3396), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3404), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3421), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3342), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3397), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3405), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3422), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3430), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3438), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3439), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3451), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3457), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3447), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3453), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3458), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3468), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3473), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3512), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3463), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3469), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3473), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3513), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3444), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3470), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3514), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3466), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3471), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3475), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 12, 5, 22, 1, 41, 247, DateTimeKind.Local).AddTicks(3516) });
        }
    }
}
