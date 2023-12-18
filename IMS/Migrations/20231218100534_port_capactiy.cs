using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class port_capactiy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "RequestHosts",
                newName: "UpgradeCapacity");

            migrationBuilder.AddColumn<List<int>>(
                name: "Capacities",
                table: "RequestHosts",
                type: "integer[]",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5517), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "6449de8c-b180-4f7f-84b5-14aaf04a5d52", new DateTime(2023, 12, 18, 17, 5, 32, 294, DateTimeKind.Local).AddTicks(698), new DateTime(2023, 12, 18, 17, 5, 32, 294, DateTimeKind.Local).AddTicks(713), new List<string>(), "AQAAAAIAAYagAAAAEHo+ElMvpONiCg5wykRlgVEb7v8eUkw87zIvx7gb63YXtM8oy7qmmtM56GLwCpUcag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c98446cd-d55e-4bcf-9b6c-17ba7bd57c83", new DateTime(2023, 12, 18, 17, 5, 32, 446, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 12, 18, 17, 5, 32, 446, DateTimeKind.Local).AddTicks(4632), new List<string>(), "AQAAAAIAAYagAAAAEGlutAzDeRDhyG4OsTsmcKXDyOQMKcQ54yGNNkl4tcu3hp+kdWA/kZTUvBo4l3/GZw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a4f9b431-7b0a-4881-b651-0b435b256a47", new DateTime(2023, 12, 18, 17, 5, 32, 188, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 12, 18, 17, 5, 32, 188, DateTimeKind.Local).AddTicks(8785), new List<string>(), "AQAAAAIAAYagAAAAELXWWztCnMISAw5J/4HEQnfltMqy/60H9uJ73TXlgruK9yvc4NLPgkC5P1e+6ZOZWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "78427bd5-2563-43a2-b770-c1e1147b5464", new DateTime(2023, 12, 18, 17, 5, 32, 107, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 12, 18, 17, 5, 32, 107, DateTimeKind.Local).AddTicks(4010), new List<string>(), "AQAAAAIAAYagAAAAELm54G1vzCOfzF8U9ntzKJPFCG3KnNdde34Z91/w6wbqMQXs1GYsfXRe3Z3nwi0bZA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5322), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5470), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5479), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5486), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5493), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5535), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5585), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5594), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5602), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5658), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5667), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5674), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5595), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5660), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5668), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5675), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5542), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5579), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5588), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5661), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5669), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5676), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5662), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5670), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5677), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5663), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5670), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5678), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5555), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5582), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5591), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5663), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5671), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5679), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5583), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5664), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5672), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5680), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5593), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5665), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5673), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5681), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5695), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5705), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5686), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5691), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5696), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5706), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5711), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5716), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5687), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5702), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5707), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5688), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5693), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5698), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5713), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5689), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5694), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5699), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5704), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5709), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5719), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 12, 18, 17, 5, 32, 103, DateTimeKind.Local).AddTicks(5724) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacities",
                table: "RequestHosts");

            migrationBuilder.RenameColumn(
                name: "UpgradeCapacity",
                table: "RequestHosts",
                newName: "Capacity");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4981), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "d1012c43-2157-4a57-8319-62dcdc378615", new DateTime(2023, 12, 16, 0, 15, 5, 567, DateTimeKind.Local).AddTicks(5582), new DateTime(2023, 12, 16, 0, 15, 5, 567, DateTimeKind.Local).AddTicks(5598), new List<string>(), "AQAAAAIAAYagAAAAEFaNkUwYsaXcqsA6NIFfLg7F9VxdpbG7eLg+KbYVgv/JQanjSSMm0hvzpgUxPEkGiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "8d3ac826-8926-44c2-9c82-1a162308d2db", new DateTime(2023, 12, 16, 0, 15, 5, 682, DateTimeKind.Local).AddTicks(1916), new DateTime(2023, 12, 16, 0, 15, 5, 682, DateTimeKind.Local).AddTicks(1927), new List<string>(), "AQAAAAIAAYagAAAAEIAXWSLlMh/e9J1YPgQVxVqoed4pdzTTzR+ug3lDyWlt15g/3WO/gy4/u2TFflzSmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "2cff053b-f858-40de-bfae-6e6cd8ab8cde", new DateTime(2023, 12, 16, 0, 15, 5, 301, DateTimeKind.Local).AddTicks(4936), new DateTime(2023, 12, 16, 0, 15, 5, 301, DateTimeKind.Local).AddTicks(4948), new List<string>(), "AQAAAAIAAYagAAAAEM/hwNGBKlOPq/QBdtVrzq4dP/1Zs3A31rIkkGultobYlsxmOlFnntcfyZJu2zx4LQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "6494099c-4e4c-4aea-b9ca-a6f7132e9ede", new DateTime(2023, 12, 16, 0, 15, 5, 154, DateTimeKind.Local).AddTicks(9869), new DateTime(2023, 12, 16, 0, 15, 5, 154, DateTimeKind.Local).AddTicks(9881), new List<string>(), "AQAAAAIAAYagAAAAEHvVglFxqEtfJe5FhT+Lm/ElbljSzmFB71FBSNZsz3MMtZRyQ3DTybvlWvfw3FbExg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4779), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4904), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4923), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4950), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5010), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5060), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5177), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5202), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5015), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5062), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5179), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5203), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5017), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5193), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5205), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5019), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5143), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5155), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5169), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5182), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5194), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5020), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5145), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5196), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5035), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5146), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5172), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5197), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5148), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5186), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5211), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5135), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5188), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5201), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5213), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5215), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5225), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5241), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5258), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5343), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5353), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5218), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5227), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5235), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5243), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5251), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5259), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5346), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5355), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5229), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5237), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5245), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5253), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5261), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5348), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5356), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5222), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5238), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5246), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5254), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5262), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5358), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5232), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5248), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5256), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5264), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5351), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5359), new DateTime(2023, 12, 16, 0, 15, 5, 146, DateTimeKind.Local).AddTicks(5360) });
        }
    }
}
