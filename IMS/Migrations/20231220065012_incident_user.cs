using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class incident_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_AspNetUsers_UserId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_UserId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Incidents");

            migrationBuilder.CreateTable(
                name: "IncidentUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Action = table.Column<int>(type: "integer", nullable: false),
                    IncidentId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncidentUsers_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(960), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(974), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "31ed333b-5922-437f-85f1-f0926614869e", new DateTime(2023, 12, 20, 13, 50, 11, 266, DateTimeKind.Local).AddTicks(692), new DateTime(2023, 12, 20, 13, 50, 11, 266, DateTimeKind.Local).AddTicks(704), new List<string>(), "AQAAAAIAAYagAAAAEKN1t8eexSH/WCKGWKWU5jFlRMreLo9cD6NoY8s3kRVe1R7+QqZkKKxKHGlamfaBFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "e93ebf50-a41c-4386-b79a-39ceb3865468", new DateTime(2023, 12, 20, 13, 50, 11, 339, DateTimeKind.Local).AddTicks(6909), new DateTime(2023, 12, 20, 13, 50, 11, 339, DateTimeKind.Local).AddTicks(6922), new List<string>(), "AQAAAAIAAYagAAAAENpyw7gfCMRHBTv7hwL0gehF8XHOhWYwpr7X8rnTpAoQS18dM6eMNlKpYSqlmO02kw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "0a3a6ca8-0652-4289-9b5f-dce128543ffe", new DateTime(2023, 12, 20, 13, 50, 11, 167, DateTimeKind.Local).AddTicks(6952), new DateTime(2023, 12, 20, 13, 50, 11, 167, DateTimeKind.Local).AddTicks(6965), new List<string>(), "AQAAAAIAAYagAAAAEJKgi3JnGXxtdBhKjkKd3vUcNYOGpm9Q9r8DzXG7bA/Wa1iMV+E/JS3riTqRmzqHNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "757f3b7a-29d9-4534-8993-e8fed11b8d12", new DateTime(2023, 12, 20, 13, 50, 11, 99, DateTimeKind.Local).AddTicks(1653), new DateTime(2023, 12, 20, 13, 50, 11, 99, DateTimeKind.Local).AddTicks(1666), new List<string>(), "AQAAAAIAAYagAAAAEMTCg2r3dL5jVgSjv9fX4OOzD1lrgbnkdG8YraRunTRLvFErGethSh/I4koFB6szvA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(832), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(906), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(919), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(930), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(940), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(994), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1032), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1050), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1111), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1118), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1006), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1034), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1051), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1059), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1104), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1111), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1119), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1008), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1035), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1044), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1052), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1096), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1105), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1120), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1009), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1036), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1045), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1053), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1098), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1106), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1113), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1121), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1010), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1037), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1046), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1054), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1099), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1107), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1114), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1122), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1017), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1100), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1108), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1115), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1123), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1018), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1039), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1048), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1109), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1124), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1040), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1049), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1056), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1102), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1109), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1117), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1125), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1126), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1133), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1138), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1143), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1148), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1158), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1162), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1139), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1144), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1149), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1154), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1158), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1130), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1135), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1140), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1150), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1155), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1159), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1164), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1131), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1141), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1160), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1165), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1137), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1142), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1147), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1152), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1161), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1166), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.CreateIndex(
                name: "IX_IncidentUsers_IncidentId",
                table: "IncidentUsers",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentUsers_UserId",
                table: "IncidentUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncidentUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Incidents",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6706), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "8058a32f-5630-4b6e-bbe5-763f4f95e9aa", new DateTime(2023, 12, 20, 0, 25, 26, 76, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 12, 20, 0, 25, 26, 76, DateTimeKind.Local).AddTicks(2908), new List<string>(), "AQAAAAIAAYagAAAAECKDN/In6EfXgSpOguVN2tJIGWF8EHjW5ZfLMc2EM1JBi6NRNP2qYXnAt3kJAc7hGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "59a72948-f37c-4a77-bb68-2ab3703f344f", new DateTime(2023, 12, 20, 0, 25, 26, 215, DateTimeKind.Local).AddTicks(4702), new DateTime(2023, 12, 20, 0, 25, 26, 215, DateTimeKind.Local).AddTicks(4715), new List<string>(), "AQAAAAIAAYagAAAAEDHnadfsN9NZAlAwoEzrXCjQFhuIjTwEZfKYwovJJScBuWajivvlfF+7ucG709E1mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "e01d4519-e3c2-4546-ae78-cb782dcde95a", new DateTime(2023, 12, 20, 0, 25, 25, 983, DateTimeKind.Local).AddTicks(4244), new DateTime(2023, 12, 20, 0, 25, 25, 983, DateTimeKind.Local).AddTicks(4263), new List<string>(), "AQAAAAIAAYagAAAAEEuRQ0o/7eczvYzGYt/bzxGf8K7nxXbE9vP1gnpRLk9FeNp8yR2jmdeCKRLxhHBFtw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "777296a8-e3cc-4894-84b7-8a2b194ae872", new DateTime(2023, 12, 20, 0, 25, 25, 869, DateTimeKind.Local).AddTicks(6814), new DateTime(2023, 12, 20, 0, 25, 25, 869, DateTimeKind.Local).AddTicks(6824), new List<string>(), "AQAAAAIAAYagAAAAEPgEmhaHq82gNS/FjJEz1AHM3y/Af9GRItyyDDb00sOa9AP9n4aNhiEZGnfSDngzmg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6665), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6672), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6752), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6771), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6817), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6826), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6841), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6763), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6827), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6842), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6718), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6755), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6765), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6773), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6820), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6828), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6836), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6843), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6719), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6766), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6774), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6829), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6844), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6775), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6830), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6845), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6758), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6768), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6823), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6831), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6846), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6759), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6769), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6839), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6847), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6816), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6825), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6833), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6861), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6866), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6871), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6857), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6876), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6881), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6886), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6853), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6858), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6868), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6887), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6854), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6859), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6864), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6869), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6873), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6878), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6883), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6888), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6855), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6869), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6874), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6879), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6884), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6889), new DateTime(2023, 12, 20, 0, 25, 25, 866, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_UserId",
                table: "Incidents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_AspNetUsers_UserId",
                table: "Incidents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
