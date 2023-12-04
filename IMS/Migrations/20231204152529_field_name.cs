using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class field_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "MasterIp",
                table: "ServerAllocations",
                newName: "MasterIpAddress");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4279), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bfe60f7b-315d-4621-8986-f69f28952ea3", new DateTime(2023, 12, 4, 22, 25, 28, 83, DateTimeKind.Local).AddTicks(7437), new DateTime(2023, 12, 4, 22, 25, 28, 83, DateTimeKind.Local).AddTicks(7455), "AQAAAAIAAYagAAAAEDVTwuEUbk18rRAfzki4vD0qzxrdIlxp7GBjzQB/URzYmE0YqGiCLvtnBKNx8PujFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "5cb392cf-9509-4ea6-8d5c-4a2774272740", new DateTime(2023, 12, 4, 22, 25, 27, 873, DateTimeKind.Local).AddTicks(5864), new DateTime(2023, 12, 4, 22, 25, 27, 873, DateTimeKind.Local).AddTicks(5876), "AQAAAAIAAYagAAAAEBFUVHRZiepxRP+cVyyv3P3d7CubyY/Iei/k7p34avcP0SAvp13c1YLjP6CPlhSXuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "258951d3-1dc7-48ab-b5d5-de7396daf078", new DateTime(2023, 12, 4, 22, 25, 27, 974, DateTimeKind.Local).AddTicks(6363), new DateTime(2023, 12, 4, 22, 25, 27, 974, DateTimeKind.Local).AddTicks(6375), "AQAAAAIAAYagAAAAENJFRB1OiA85yKc3A1eEfLwpAXGEISZpTkl4PK3Rq+hP6aPP+p03f1QYU3b0oHjcyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "41635439-8f6d-4af7-b953-9af615f71104", new DateTime(2023, 12, 4, 22, 25, 27, 778, DateTimeKind.Local).AddTicks(3923), new DateTime(2023, 12, 4, 22, 25, 27, 778, DateTimeKind.Local).AddTicks(3936), "AQAAAAIAAYagAAAAEOzmxwbVtM+/bmqAsbD+QgjMts7l93qfijFTZVU2PkHS8fr1N5smq5CHC0QkbP2F6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b2992567-aa79-4fc5-944f-235c12ad693c", new DateTime(2023, 12, 4, 22, 25, 27, 693, DateTimeKind.Local).AddTicks(97), new DateTime(2023, 12, 4, 22, 25, 27, 693, DateTimeKind.Local).AddTicks(102), "AQAAAAIAAYagAAAAELgvszFL8bWjhaJEqm59Vf6dpzi5TBnfcA8ugE2v9Oce+JyGpHo6XORDMb279VuJww==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4102), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4220), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4228), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4305), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4356), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4365), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4374), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4443), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4452), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4319), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4347), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4357), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4366), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4376), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4434), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4444), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4320), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4348), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4358), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4368), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4378), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4436), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4445), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4454), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4328), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4360), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4369), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4379), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4437), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4446), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4329), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4351), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4361), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4370), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4457), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4341), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4352), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4362), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4371), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4381), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4449), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4342), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4353), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4363), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4372), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4382), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4459), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4344), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4354), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4373), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4441), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4451), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4469), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4475), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4481), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4487), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4493), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4499), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4504), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4464), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4476), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4482), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4488), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4500), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4506), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4466), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4472), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4478), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4483), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4489), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4501), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4507), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4473), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4479), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4485), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4496), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4508), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4468), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4474), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4486), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4497), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4503), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4509), new DateTime(2023, 12, 4, 22, 25, 27, 689, DateTimeKind.Local).AddTicks(4509) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MasterIpAddress",
                table: "ServerAllocations",
                newName: "MasterIp");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6188), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6202), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b3daba6d-2548-4d17-83ae-c28ec74d65c4", new DateTime(2023, 12, 4, 16, 6, 7, 132, DateTimeKind.Local).AddTicks(617), new DateTime(2023, 12, 4, 16, 6, 7, 132, DateTimeKind.Local).AddTicks(629), "AQAAAAIAAYagAAAAEOui4pWmKMqj+szufGxd2vTH/VyKl0xZmhz53Q/Mc3gTufOLPZEdT9jwKeve7T5QrA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e3431dfd-c091-4ae6-a69d-939e92011b1a", new DateTime(2023, 12, 4, 16, 6, 6, 925, DateTimeKind.Local).AddTicks(8259), new DateTime(2023, 12, 4, 16, 6, 6, 925, DateTimeKind.Local).AddTicks(8270), "AQAAAAIAAYagAAAAEA4U07eE96gX+cSENMz6zNRWp30Ii4qRLIb1KsNi7LCIaM1mKFW3WFP+tyEs5ioixw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "af45e08c-8186-415a-9bf3-05360422faf3", new DateTime(2023, 12, 4, 16, 6, 7, 9, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 12, 4, 16, 6, 7, 9, DateTimeKind.Local).AddTicks(6997), "AQAAAAIAAYagAAAAELlvfsX9pJP1ELyGtE6rJYouAVnVsMW+9zEZIPC4qNuC9qi/RT+MgVGoiqY7DV2laQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "39a19a3f-a753-44b8-aa2a-f1456895c46e", new DateTime(2023, 12, 4, 16, 6, 6, 858, DateTimeKind.Local).AddTicks(67), new DateTime(2023, 12, 4, 16, 6, 6, 858, DateTimeKind.Local).AddTicks(79), "AQAAAAIAAYagAAAAEF2IsLtUefpYt+z1wGMbXh6tMmDJf3YndT+Ep7F8nz5aK4PukUeZQI2TFU7RDyOqpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7c1c5183-4599-4a88-ac22-91d5e1cb3a3c", new DateTime(2023, 12, 4, 16, 6, 6, 790, DateTimeKind.Local).AddTicks(5672), new DateTime(2023, 12, 4, 16, 6, 6, 790, DateTimeKind.Local).AddTicks(5679), "AQAAAAIAAYagAAAAEEhNsrghgfUJHJEz89YxlIbmqsDbD8hv9avod9AOFwiswxyFK70dohHb68/OcGvajA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6132), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6162), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6247), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6318), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6249), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6272), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6241), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6221), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6243), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6322), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6329), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6235), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6252), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6315), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6246), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6332), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6339), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6358), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6363), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6368), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6340), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6359), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6364), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6369), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6336), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6365), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6370), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6337), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6347), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6366), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6371), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6362), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6372), new DateTime(2023, 12, 4, 16, 6, 6, 786, DateTimeKind.Local).AddTicks(6372) });
        }
    }
}
