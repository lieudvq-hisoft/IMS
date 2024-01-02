using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class cccd_for_contact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CCCD",
                table: "Contacts",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3867), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "3fcabf7b-9d9d-4f68-bbf3-568c0fe8b641", new DateTime(2024, 1, 2, 22, 30, 44, 953, DateTimeKind.Local).AddTicks(3437), new DateTime(2024, 1, 2, 22, 30, 44, 953, DateTimeKind.Local).AddTicks(3450), new List<string>(), "AQAAAAIAAYagAAAAEGcCc8BkFAeaCBJ7SDko1dC/DSpaUtT1U+hwRlCS4F7CBmfl90IppuxhWpb1Vhltag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "046ec74c-5284-49ff-bd12-7f41909dc9ee", new DateTime(2024, 1, 2, 22, 30, 45, 22, DateTimeKind.Local).AddTicks(7914), new DateTime(2024, 1, 2, 22, 30, 45, 22, DateTimeKind.Local).AddTicks(7926), new List<string>(), "AQAAAAIAAYagAAAAEF4Q7Q+0EFP4XRPRDGh7gJqoMQJDWxFILOiM3obSBjU8gnw6NCNinwUR/LHhRVmWSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b0c9566f-ee8d-4d1b-9357-13aed6453dba", new DateTime(2024, 1, 2, 22, 30, 44, 881, DateTimeKind.Local).AddTicks(7738), new DateTime(2024, 1, 2, 22, 30, 44, 881, DateTimeKind.Local).AddTicks(7750), new List<string>(), "AQAAAAIAAYagAAAAEBDLZqSevTAJ7iP3ZMY4GdN8WDAG/fSwKlUxfHvWw+5BvoRWdb5bzKRdmV6FJqQ9Yg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "743bba43-b62c-4e2b-a3eb-685e58d6c4b1", new DateTime(2024, 1, 2, 22, 30, 44, 814, DateTimeKind.Local).AddTicks(3865), new DateTime(2024, 1, 2, 22, 30, 44, 814, DateTimeKind.Local).AddTicks(3869), new List<string>(), "AQAAAAIAAYagAAAAEDwJTAIr5iVKR9xDryL1L/UaV1m7YHgVuqsFr1IFdcJ+1vV9F+j2lbcyPinvqck4fQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3835), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3886), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3904), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3929), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3938), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3989), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3997), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4004), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3906), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3931), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3939), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3998), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4013), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3892), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3932), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4006), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4014), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3893), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3924), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4000), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4015), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3894), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4001), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4008), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3896), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3926), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3935), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3942), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3994), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4002), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4009), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3898), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3943), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3995), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4002), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4010), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4017), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3899), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3928), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3937), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3944), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3996), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4003), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4026), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4031), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4036), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4041), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4055), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4022), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4027), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4032), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4046), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4051), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4028), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4038), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4047), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4052), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4057), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4024), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4029), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4034), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4043), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4048), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4053), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4057), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4025), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4030), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4044), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4049), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4054), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4059) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CCCD",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9019), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9033), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "980add70-b4bc-49e4-a454-d5acb8ea9439", new DateTime(2024, 1, 1, 16, 52, 55, 727, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 1, 1, 16, 52, 55, 727, DateTimeKind.Local).AddTicks(3723), new List<string>(), "AQAAAAIAAYagAAAAELG+oSzpwCbxOlPhHtbdePdzABAFntaNZg8jyxX2bXX7sDblrUpe5k0LgzVmL3+eQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "108e88f3-600a-4dcb-a08a-04bd63ce9c37", new DateTime(2024, 1, 1, 16, 52, 55, 794, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 1, 1, 16, 52, 55, 794, DateTimeKind.Local).AddTicks(4348), new List<string>(), "AQAAAAIAAYagAAAAEASCAFv9/imjmnTfbCmTTGhTlILsYQO1VdpBBsGlr3/bwgu4B472FXhSRWRYV9aZTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "6abbadbf-931b-47ae-977a-da4e16f8e890", new DateTime(2024, 1, 1, 16, 52, 55, 651, DateTimeKind.Local).AddTicks(843), new DateTime(2024, 1, 1, 16, 52, 55, 651, DateTimeKind.Local).AddTicks(858), new List<string>(), "AQAAAAIAAYagAAAAEDFLMZ/bGF1980z47T6GJHJDYRcTXHx7wY32biYBxziQr9csLredDoX7jNQlsNRStw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "49b26ea2-8f22-4bc0-9ad6-20ea3750d8d4", new DateTime(2024, 1, 1, 16, 52, 55, 561, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 1, 1, 16, 52, 55, 561, DateTimeKind.Local).AddTicks(7493), new List<string>(), "AQAAAAIAAYagAAAAEADtuAVKdSLgiimyN3+aMRD6a8LjpuLTJCsvO1tTvo++ptKras0BejI8wJKWq/Dtuw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(8851), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9038), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9051), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9060), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9068), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9076), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9133), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9053), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9061), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9069), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9127), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9134), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9054), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9062), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9070), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9128), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9044), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9055), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9064), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9121), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9128), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9136), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9143), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9045), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9064), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9072), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9048), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9057), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9123), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9145), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9049), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9058), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9066), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9074), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9131), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9067), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9075), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9132), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9139), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9160), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9165), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9184), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9162), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9167), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9177), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9182), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9187), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9155), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9179), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 1, 1, 16, 52, 55, 556, DateTimeKind.Local).AddTicks(9189) });
        }
    }
}
