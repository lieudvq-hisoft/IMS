using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class incident : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fullname",
                table: "AspNetUsers",
                type: "varchar(1000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1000)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Solution = table.Column<string>(type: "text", nullable: true),
                    ResolvByClient = table.Column<string>(type: "text", nullable: false),
                    Document = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ServerAllocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_ServerAllocations_ServerAllocationId",
                        column: x => x.ServerAllocationId,
                        principalTable: "ServerAllocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncidentAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IncidentId = table.Column<int>(type: "integer", nullable: false),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentAppointments_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncidentAppointments_Incidents_IncidentId",
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
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8778), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c9c3b707-eb17-4c95-9bb6-683e77f44371", new DateTime(2023, 12, 19, 23, 27, 55, 261, DateTimeKind.Local).AddTicks(2224), new DateTime(2023, 12, 19, 23, 27, 55, 261, DateTimeKind.Local).AddTicks(2238), new List<string>(), "AQAAAAIAAYagAAAAEGwUAAx1Eac+iDoEl7ANzuH5LcV/c0Scer+u3aOnoxAeZQzCSANtzy9kWsqMvvDldg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "f371dceb-6c82-4e0d-adc1-e94e16d6f590", new DateTime(2023, 12, 19, 23, 27, 55, 351, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 12, 19, 23, 27, 55, 351, DateTimeKind.Local).AddTicks(6880), new List<string>(), "AQAAAAIAAYagAAAAEBakZRZZHoEa9c49B8lW9Nx8h9dgPh8JY1FeeLtWiFnwXr4y/I2O8e805J1mG8edXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "36dc96c2-d5d4-4250-82c8-eb3b81478e33", new DateTime(2023, 12, 19, 23, 27, 55, 175, DateTimeKind.Local).AddTicks(4979), new DateTime(2023, 12, 19, 23, 27, 55, 175, DateTimeKind.Local).AddTicks(4991), new List<string>(), "AQAAAAIAAYagAAAAEGLKgSS1X6dtq3eolhBho0unrTQC+id1bHZI6T9mRdv4gE2uxG6eYmwb7fWJyEj/XQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c19ee94a-53fb-4c21-a23e-1f2118bf31aa", new DateTime(2023, 12, 19, 23, 27, 55, 103, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 12, 19, 23, 27, 55, 103, DateTimeKind.Local).AddTicks(2768), new List<string>(), "AQAAAAIAAYagAAAAEJovTcBYjNpwWIz0vUxMOSXe+kzkVslHWaa4kVPyFODV8ZacJj8f7Ln2vdjdTnFQVw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8631), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8723), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8885), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8944), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8869), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8946), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8881), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8947), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8821), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8883), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8941), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8981), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8986), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8976), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8992), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8955), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8967), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8972), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8983), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8988), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8968), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8973), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8979), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8989), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8994), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8964), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8974), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8985), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.CreateIndex(
                name: "IX_IncidentAppointments_AppointmentId",
                table: "IncidentAppointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentAppointments_IncidentId",
                table: "IncidentAppointments",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ServerAllocationId",
                table: "Incidents",
                column: "ServerAllocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_UserId",
                table: "Incidents",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncidentAppointments");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.AlterColumn<string>(
                name: "Fullname",
                table: "AspNetUsers",
                type: "varchar(1000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(1000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1186), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1200), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "4f9287f9-90c8-417c-b4cb-7e6ba58b780b", new DateTime(2023, 12, 19, 16, 31, 47, 82, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 12, 19, 16, 31, 47, 82, DateTimeKind.Local).AddTicks(2868), new List<string>(), "AQAAAAIAAYagAAAAEGrL4zvCIh+ooIXYwU7JkcTT0u+n/A9GwfK/wKJ2fokS0avtKh7k/9omn5xfO1I4Ig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "39c89ac0-7888-4c98-8dda-f719deb18920", new DateTime(2023, 12, 19, 16, 31, 47, 150, DateTimeKind.Local).AddTicks(4122), new DateTime(2023, 12, 19, 16, 31, 47, 150, DateTimeKind.Local).AddTicks(4135), new List<string>(), "AQAAAAIAAYagAAAAEJPu+xhWUH4JrpqBk6Imevo/uKltCGkqac9risutE0rHRTarkzmK6ApzjaeM1PTxfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "51f7872f-eab7-425b-bace-14fa78b4e0ea", new DateTime(2023, 12, 19, 16, 31, 47, 13, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 12, 19, 16, 31, 47, 13, DateTimeKind.Local).AddTicks(6043), new List<string>(), "AQAAAAIAAYagAAAAEE+uvhITVs/m0KQxkhZWRcySa/ywwTGzeDKKQxnpEBKlkfB9cAkSMKuSXFo3NlHnqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c90e4fd3-f4bf-4906-8c0d-aec515f50f45", new DateTime(2023, 12, 19, 16, 31, 46, 943, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 12, 19, 16, 31, 46, 943, DateTimeKind.Local).AddTicks(3949), new List<string>(), "AQAAAAIAAYagAAAAEKd36a0nvYia5nYYbujAUyllhaxzoV3e7oAekAnaHdf2eoc/KVQiAvAZiw7w27i0kw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1022), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1161), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1205), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1220), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1244), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1252), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1299), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1307), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1211), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1222), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1230), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1237), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1245), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1300), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1307), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1212), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1238), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1246), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1301), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1308), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1213), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1232), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1239), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1294), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1302), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1309), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1214), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1224), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1240), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1248), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1295), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1303), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1310), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1216), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1225), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1241), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1249), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1296), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1304), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1311), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1217), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1226), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1234), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1242), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1250), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1297), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1305), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1312), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1218), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1227), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1235), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1243), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1298), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1306), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1313), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1317), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1324), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1329), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1333), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1338), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1343), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1347), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1352), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1320), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1325), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1330), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1339), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1343), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1348), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1353), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1321), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1326), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1331), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1335), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1340), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1344), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1349), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1354), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1322), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1327), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1332), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1336), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1341), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1345), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1350), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1355), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1323), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1328), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1332), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1337), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1342), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1346), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1351), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1356), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1356) });
        }
    }
}
