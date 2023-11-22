using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class user_customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCustomers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserCustomers_CustomerId",
                table: "UserCustomers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCustomers_UserId",
                table: "UserCustomers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCustomers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6474), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c684f6d5-a6b5-41b8-8d60-0b3551c97b37", new DateTime(2023, 11, 22, 21, 24, 54, 181, DateTimeKind.Local).AddTicks(8165), new DateTime(2023, 11, 22, 21, 24, 54, 181, DateTimeKind.Local).AddTicks(8179), "AQAAAAIAAYagAAAAECSuA+Ha0T5urGKlrkl2FOhO1V2pqewJVe8jiFQjB0ey6W5oNxEzvKuDvLohk4K75A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0da04f0f-cfa8-4218-8d60-e274e468e70e", new DateTime(2023, 11, 22, 21, 24, 54, 26, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 11, 22, 21, 24, 54, 26, DateTimeKind.Local).AddTicks(4480), "AQAAAAIAAYagAAAAEJ8foiIWG3mQGPRvsXHbh9XNyR3KMzdAb9PebuzZAtB1YZ/u69Kej/Rp4qtjgrUT5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "15bd1707-0d34-4af6-9f5c-a6651983f750", new DateTime(2023, 11, 22, 21, 24, 54, 103, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 11, 22, 21, 24, 54, 103, DateTimeKind.Local).AddTicks(5098), "AQAAAAIAAYagAAAAEP9XqLAxD8dAAcjQlrhrk2Cm3PcQE4jFxtY+dPAItOwPDCuY79qB68HothOH1KTbUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ac705d49-1879-4075-b15a-93d87b78a22b", new DateTime(2023, 11, 22, 21, 24, 53, 955, DateTimeKind.Local).AddTicks(3346), new DateTime(2023, 11, 22, 21, 24, 53, 955, DateTimeKind.Local).AddTicks(3358), "AQAAAAIAAYagAAAAEEsV+FFxJ8H/KvAo5hueCnvn+6YEECJ/RJ2nChgAj3tH1+VvjudcU8VEcdAzzRO7ow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0e3878ca-cc19-42d9-a287-a36f1483e328", new DateTime(2023, 11, 22, 21, 24, 53, 885, DateTimeKind.Local).AddTicks(9723), new DateTime(2023, 11, 22, 21, 24, 53, 885, DateTimeKind.Local).AddTicks(9727), "AQAAAAIAAYagAAAAEA/5IZeh7XXYJfSWr/jusR2LRatmpx4sIU1Mki0X3Ye3gHYb0CGrzNTR1QMSGm34iQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6208), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6322), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6374), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6388), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6432), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6410), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6507), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6516), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6568), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6576), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6585), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6592), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6499), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6509), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6517), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6569), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6578), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6586), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6593), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6601), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6518), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6579), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6594), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6602), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6501), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6511), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6519), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6571), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6595), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6603), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6502), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6512), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6520), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6572), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6581), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6588), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6596), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6604), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6565), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6573), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6582), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6589), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6597), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6605), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6514), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6566), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6574), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6583), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6590), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6598), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6606), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6506), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6575), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6584), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6591), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6599), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6607), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6608), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6614), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6619), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6629), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6639), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6625), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6635), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6645), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6611), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6616), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6621), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6626), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6631), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6636), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6641), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6612), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6622), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6637), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6642), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6613), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6618), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6623), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6633), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6638), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6643), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6681), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6681) });
        }
    }
}
