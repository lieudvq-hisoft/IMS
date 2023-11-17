using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_expand_location_is_server : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsServer",
                table: "RequestExpandLocations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8629), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "790a71e0-e14d-46cb-a364-5d20f39e531d", new DateTime(2023, 11, 17, 17, 1, 19, 612, DateTimeKind.Local).AddTicks(7463), new DateTime(2023, 11, 17, 17, 1, 19, 612, DateTimeKind.Local).AddTicks(7476), "AQAAAAIAAYagAAAAECLcNW42PViwywlV/T0caPKXpvQ/u47FPmb8BiAXpkGxwXcpwpbEydb6ua5pSMM8OA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f1c8f8b8-ca3b-45aa-a8a4-4ee4831a97e1", new DateTime(2023, 11, 17, 17, 1, 19, 450, DateTimeKind.Local).AddTicks(9424), new DateTime(2023, 11, 17, 17, 1, 19, 450, DateTimeKind.Local).AddTicks(9435), "AQAAAAIAAYagAAAAECZ1SQUTtGvDYSPK8EnDSsAbcE58XZeayUygIRZ8NSqv4Ip4aZoijLVp5l3cHkq0bg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "054536fd-f52b-42b4-b37e-7d26233fa444", new DateTime(2023, 11, 17, 17, 1, 19, 520, DateTimeKind.Local).AddTicks(5305), new DateTime(2023, 11, 17, 17, 1, 19, 520, DateTimeKind.Local).AddTicks(5319), "AQAAAAIAAYagAAAAEBjAxbvPKa4IU7lwUiJPqeIHz/gj+FtEpN+B+T/hPXnRtkYQq775FesTl6lk1/BgiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b3e488d1-132a-4279-b7f7-94eafb6f3ebe", new DateTime(2023, 11, 17, 17, 1, 19, 364, DateTimeKind.Local).AddTicks(9489), new DateTime(2023, 11, 17, 17, 1, 19, 364, DateTimeKind.Local).AddTicks(9504), "AQAAAAIAAYagAAAAEMZekXXHerGsSqBxTIkTeeTW+CokB34Ghor6GWWoKcI/Gd/n1bQvdUYSTjDXfDwQvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ed999b42-a537-4f8f-85f1-4edd4db15268", new DateTime(2023, 11, 17, 17, 1, 19, 291, DateTimeKind.Local).AddTicks(5776), new DateTime(2023, 11, 17, 17, 1, 19, 291, DateTimeKind.Local).AddTicks(5788), "AQAAAAIAAYagAAAAEMOEwlTDxeIU957eNTHgQoGiYc6aP6T4/DGycowCIC8NmCglGoYbuYZ3TQ2TopuiGQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8459), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8473), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8485), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8525), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8557), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8597), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8655), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8681), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8757), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8672), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8683), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8692), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8674), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8684), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8742), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8766), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8774), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8675), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8685), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8694), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8676), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8695), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8760), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8678), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8737), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8745), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8688), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8738), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8778), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8763), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8812), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8817), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8813), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8814), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8816), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8855) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsServer",
                table: "RequestExpandLocations");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8254), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8275), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7d2f7519-87b8-464d-86e9-3e9f10683499", new DateTime(2023, 11, 17, 14, 25, 12, 756, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 11, 17, 14, 25, 12, 756, DateTimeKind.Local).AddTicks(2756), "AQAAAAIAAYagAAAAEOqY6NVhFm63Sp+zsLNWVyl8tVKlHKvzSLr8aqNK18J30Nim1YnuWwLu/x4lOfnVRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f815cef0-cfa8-45f3-a5ad-f99f49a1a242", new DateTime(2023, 11, 17, 14, 25, 12, 598, DateTimeKind.Local).AddTicks(917), new DateTime(2023, 11, 17, 14, 25, 12, 598, DateTimeKind.Local).AddTicks(931), "AQAAAAIAAYagAAAAEPNMElgVjjhRv/MrGWPHUbXhO5uANDbIL+bFFYy4XoWpYOYXmUq97G4rgPjhn2NSZg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "86ffd7ac-d3a7-4ab9-aa75-f871e0626a09", new DateTime(2023, 11, 17, 14, 25, 12, 681, DateTimeKind.Local).AddTicks(640), new DateTime(2023, 11, 17, 14, 25, 12, 681, DateTimeKind.Local).AddTicks(650), "AQAAAAIAAYagAAAAEJHwElmY1gQraFr6t2u0tA1L+MX/H122xQQhmYjVKSLP5aT4Rr0adqYZ9qTvGyylLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3e984d5c-928c-4494-8508-0b00087bf8c2", new DateTime(2023, 11, 17, 14, 25, 12, 528, DateTimeKind.Local).AddTicks(6091), new DateTime(2023, 11, 17, 14, 25, 12, 528, DateTimeKind.Local).AddTicks(6103), "AQAAAAIAAYagAAAAEDF3r6qSPzbkp8BFbOEyrUCNswwuW/KT8L9kYKEpRENlKUuBjv6zWLG+unXFM83Ddg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "21ccd8ad-a665-43a7-96e9-25b82ecd4433", new DateTime(2023, 11, 17, 14, 25, 12, 459, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 11, 17, 14, 25, 12, 459, DateTimeKind.Local).AddTicks(5008), "AQAAAAIAAYagAAAAEHbSQvOyAFChVuLv9tdRQ1ClULnn5V1fOY5rjCCytD93S5TwfBH3Y4vnsvLyJDVI9A==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8108), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8172), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8207), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8224), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8186), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8297), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8320), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8330), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8339), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8346), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8355), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8363), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8302), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8332), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8356), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8372), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8304), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8333), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8341), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8349), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8357), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8365), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8373), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8305), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8325), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8334), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8342), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8350), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8358), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8366), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8374), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8314), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8326), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8335), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8343), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8351), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8359), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8375), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8317), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8327), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8336), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8343), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8352), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8368), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8376), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8337), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8344), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8353), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8369), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8377), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8329), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8338), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8345), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8354), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8362), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8378), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8379), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8391), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8396), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8536), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8546), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8551), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8387), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8392), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8402), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8537), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8542), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8547), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8383), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8388), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8532), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8543), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8553), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8389), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8394), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8534), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8539), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8549), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8385), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8535), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8545), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8555) });
        }
    }
}
