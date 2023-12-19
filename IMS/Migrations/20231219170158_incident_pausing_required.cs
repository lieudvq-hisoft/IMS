using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class incident_pausing_required : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PausingRequired",
                table: "Incidents",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4113), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4138), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "3543118a-0cb4-4b94-bbc7-cda1b06f7ef0", new DateTime(2023, 12, 20, 0, 1, 57, 6, DateTimeKind.Local).AddTicks(1072), new DateTime(2023, 12, 20, 0, 1, 57, 6, DateTimeKind.Local).AddTicks(1093), new List<string>(), "AQAAAAIAAYagAAAAEC616ZeAuMcwYblgd6O9zeNgZlK6wqCwZo9f/DI2P7+PKGfEap6yDt3pdbi94m+J1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "10746ecb-74b3-452d-ada5-16c96adcc7c0", new DateTime(2023, 12, 20, 0, 1, 57, 165, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 12, 20, 0, 1, 57, 165, DateTimeKind.Local).AddTicks(9982), new List<string>(), "AQAAAAIAAYagAAAAELHOKVxMlF4fZql/kTT8drvi+p8t9wqvV4PZGzXQdrtQYZMk3cE2yrOkixiG7Gkklg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "daf332a4-3744-4df4-a7ee-76376c8abba5", new DateTime(2023, 12, 20, 0, 1, 56, 910, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 12, 20, 0, 1, 56, 910, DateTimeKind.Local).AddTicks(5077), new List<string>(), "AQAAAAIAAYagAAAAEOmjWd3uB1PA23NsW4ZbtkGlVbxBd4nrVv0c/WWGIZeuTu79vvECeJYSMrUPzGQkkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "4f7c5c2d-c4d1-4de9-9219-cdd79f613934", new DateTime(2023, 12, 20, 0, 1, 56, 733, DateTimeKind.Local).AddTicks(2238), new DateTime(2023, 12, 20, 0, 1, 56, 733, DateTimeKind.Local).AddTicks(2252), new List<string>(), "AQAAAAIAAYagAAAAEBb9QpfFZkbk23Y8Ou8s3AC91EQ0LYI6ytUTmRwz2v02Q7fluL7q7tX28XRJf/t2Mw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(3871), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4040), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4057), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4069), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4080), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4146), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4219), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4232), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4243), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4257), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4268), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4282), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4209), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4222), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4233), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4247), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4258), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4283), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4157), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4211), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4235), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4249), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4271), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4285), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4236), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4261), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4286), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4160), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4227), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4251), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4262), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4275), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4350), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4181), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4228), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4239), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4352), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4216), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4254), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4266), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4278), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4353), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4217), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4231), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4242), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4255), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4267), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4354), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4356), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4365), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4373), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4387), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4394), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4360), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4367), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4374), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4381), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4389), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4396), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4403), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4410), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4362), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4369), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4375), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4382), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4390), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4397), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4363), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4370), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4377), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4384), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4391), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4398), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4405), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4412), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4371), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4378), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4386), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4393), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 12, 20, 0, 1, 56, 726, DateTimeKind.Local).AddTicks(4414) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PausingRequired",
                table: "Incidents");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "937d1739-5fbb-4bb5-b019-39e0580e14d4", new DateTime(2023, 12, 19, 23, 56, 3, 635, DateTimeKind.Local).AddTicks(1852), new DateTime(2023, 12, 19, 23, 56, 3, 635, DateTimeKind.Local).AddTicks(1865), new List<string>(), "AQAAAAIAAYagAAAAEHBphBfEQEv7p+bcdFZUjBo9l7Jp4PxFLqXvf8U5K9NX9oKyk+g1C+j+GlVrktyISg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "9517c0d1-b5d7-4e0a-940a-3130a98d8633", new DateTime(2023, 12, 19, 23, 56, 3, 715, DateTimeKind.Local).AddTicks(3664), new DateTime(2023, 12, 19, 23, 56, 3, 715, DateTimeKind.Local).AddTicks(3680), new List<string>(), "AQAAAAIAAYagAAAAEL/CGYuwCGS6jT5wtFMfLPGutggn1Lpai2+k1MLawh3NU1eqNcx5mYzYvQGtCZJZ+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "66100859-21ad-4629-a3d1-a4036171e38b", new DateTime(2023, 12, 19, 23, 56, 3, 562, DateTimeKind.Local).AddTicks(586), new DateTime(2023, 12, 19, 23, 56, 3, 562, DateTimeKind.Local).AddTicks(598), new List<string>(), "AQAAAAIAAYagAAAAEFSve4l5+ucSkCKAGauI7OIGrwT0NA9kRy+G9plLgJFMJLbjU5OFrE0jSwGMUrU8KQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b50e71c7-38b5-4472-89c4-225269d87002", new DateTime(2023, 12, 19, 23, 56, 3, 480, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 12, 19, 23, 56, 3, 480, DateTimeKind.Local).AddTicks(9697), new List<string>(), "AQAAAAIAAYagAAAAEFLaN96PaeIY+gjvchTYlg6f0tVRfcI5Imebv0OxGasPR8/dHBMTKh6NPuAvizppEg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8647), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8657), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8665), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8672), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8745), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8763), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8757), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8829), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8717), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8766), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8774), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8782), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8822), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8760), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8824), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8826), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8869), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8845), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8877) });
        }
    }
}
