using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class removal_request_expand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RemovalStatus",
                table: "RequestExpands",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ForRemoval",
                table: "RequestExpandAppointments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5780), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6eab4ab2-a8f5-4cf9-8d92-af92e39f1e1d", new DateTime(2023, 11, 25, 23, 50, 41, 824, DateTimeKind.Local).AddTicks(6292), new DateTime(2023, 11, 25, 23, 50, 41, 824, DateTimeKind.Local).AddTicks(6350), "AQAAAAIAAYagAAAAEAuEsLcozzKG1QVpslbncU4ABXU23YxaQn1kM9XznsX3jz/A0RUYdyuGxiVbsQ22Yg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7cd90252-e9fd-4343-9b32-e874ffffa9e8", new DateTime(2023, 11, 25, 23, 50, 41, 676, DateTimeKind.Local).AddTicks(7002), new DateTime(2023, 11, 25, 23, 50, 41, 676, DateTimeKind.Local).AddTicks(7014), "AQAAAAIAAYagAAAAEKHi2tB6ohLG24QkKOiUIpm+ZV6ErB5KdZfLywXAZJr6Y1snG1Oyc2yGR9sVI7cAEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "277f64e6-ca75-4e63-abc6-77556118d61d", new DateTime(2023, 11, 25, 23, 50, 41, 753, DateTimeKind.Local).AddTicks(9281), new DateTime(2023, 11, 25, 23, 50, 41, 753, DateTimeKind.Local).AddTicks(9292), "AQAAAAIAAYagAAAAEPrGRGWn1MIK8LpPF7IMSbESPPUutti6oU4jOyFzg94g0zfgGLx2+XlMbjMRNGqB7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b4976463-96e6-4dec-8f01-df41787de6d5", new DateTime(2023, 11, 25, 23, 50, 41, 579, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 11, 25, 23, 50, 41, 579, DateTimeKind.Local).AddTicks(8650), "AQAAAAIAAYagAAAAEKcZUwzPAjST0MPVOMC6eBiWGF60yHzKnRzbcOXD0Su0loO2y8+M8ys+eO4FgOtspg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8de6f636-a8ab-4eda-b8db-893a0e7398ff", new DateTime(2023, 11, 25, 23, 50, 41, 502, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 11, 25, 23, 50, 41, 502, DateTimeKind.Local).AddTicks(1139), "AQAAAAIAAYagAAAAEPu7QHRgrT893NP5I35mKwvHBzqJcQiO9F4n2x5AUhj2+KECH6NB5fZyQSl24j59uw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5478), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5646), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5666), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5680), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5709), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5695), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5788), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5864), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5880), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5889), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5896), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5808), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5866), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5874), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5882), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5889), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5897), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5905), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5891), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5898), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5868), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5876), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5884), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5892), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5876), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5885), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5900), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5814), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5823), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5870), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5886), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5909), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5862), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5910), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5895), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5903), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5911), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5933), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5976), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5925), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5929), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5939), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5977), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5926), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5973), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5978), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5936), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5941), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5974), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5978), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5923), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5937), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5970), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5975), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5979), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5980) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemovalStatus",
                table: "RequestExpands");

            migrationBuilder.DropColumn(
                name: "ForRemoval",
                table: "RequestExpandAppointments");

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
    }
}
