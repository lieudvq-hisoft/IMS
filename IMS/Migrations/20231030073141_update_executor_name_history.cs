using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class update_executor_name_history : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalServices_Approver_ApproverId",
                table: "AdditionalServices");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalServices_Executer_ExecuterId",
                table: "AdditionalServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Approver_AspNetUsers_UserId1",
                table: "Approver");

            migrationBuilder.DropTable(
                name: "Executer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Approver",
                table: "Approver");

            migrationBuilder.RenameTable(
                name: "Approver",
                newName: "Approvers");

            migrationBuilder.RenameColumn(
                name: "ExecuterId",
                table: "AdditionalServices",
                newName: "ExecutorId");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalServices_ExecuterId",
                table: "AdditionalServices",
                newName: "IX_AdditionalServices_ExecutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Approver_UserId1",
                table: "Approvers",
                newName: "IX_Approvers_UserId1");

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialDateStop",
                table: "Colocations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Time",
                table: "ColocationHistories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Approvers",
                table: "Approvers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Executors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Executors_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8205), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80ef2914-3bdb-4d62-8110-5d95e089ac62", "AQAAAAIAAYagAAAAECZs0ZHd460idxU/xMQ4TRKcHUgPFuKN8/MRjCedTtkF5o5HlMjo145BKfA/pWF7EQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd0e687f-4276-42a0-a2d4-5e4b22d99126", "AQAAAAIAAYagAAAAEJ0ZjEcGxHuKZdXT0AOlKHt2JiuYSdNRBO5TvzD+g/TlHnZyj8UUQrIrMLPNC5GwKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a39e1d4-0f52-4e76-a817-03652adf2a54", "AQAAAAIAAYagAAAAEMcf06U1WFDCj0IbWk6LgNFx6wEGTrCbCp9ZpIWt+lBlo1h0CJggcKfMIRxvc4tPHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7b6db85-c667-482c-9e1d-41a008a0c4cc", "AQAAAAIAAYagAAAAECPSjB/c7zZEMfFSeMYbiDz5WYGFRQDqNkjMIOrTEy0xt+JNoqJLMvJmHvlFCAYMyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "556b32e5-ae29-4463-9f71-91660d00e6b4", "AQAAAAIAAYagAAAAEDuIe3LsL67MT4i21SAHU8kdOhOfJuHrae0Je0skR+a2gOvVFEP8l+bZ2DrUi3FYtg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(4953), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5102), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9542), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9550), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9559), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9562), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9567), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9571), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9575), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9579), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9583), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9587), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9591), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9595), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9599), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9603), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9606), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9610), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9622), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9629), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9633), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9637), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9645), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9649), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9653), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9656), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9664), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9668), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9672), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9703), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9710), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9714), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9731), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9735), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9743), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9754), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9761), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9765), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9769), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9787), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9791), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9798), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9809), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9813), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9817), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9836), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9839), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9843), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9851), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9854), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9862), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9869), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9876), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9899), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9953), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9957), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9983), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(2), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(6), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(10), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(13), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(17), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(21), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(40), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(48), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(52), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(59), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(63), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(67), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(70), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(74), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(83), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(87), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(94), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(98), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(101), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(105), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(109), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(113), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(117), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(125), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(132), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(140), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(147), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(151), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(155), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(159), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(169), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(176), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(180), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(184), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(188), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(192), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(196), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(200), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(203), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(207), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(211), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(219), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(222), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(230), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(234), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(241), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(245), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(249), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(253), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(257), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(261), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(278), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(286), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(297), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(328), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(336), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(343), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(347), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(351), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(358), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(369), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9483), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9513), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9522), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8213), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8310), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8325), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8333), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8341), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8231), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8311), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8327), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8334), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8342), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8222), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8232), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8312), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8320), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8335), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8343), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8233), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8321), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8329), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8336), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8344), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8362), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8224), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8234), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8314), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8322), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8329), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8337), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8356), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8363), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8226), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8236), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8315), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8322), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8330), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8338), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8357), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8227), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8307), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8316), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8331), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8339), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8358), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8365), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8228), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8308), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8317), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8332), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8359), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8366), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8374), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8378), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8383), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8387), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8392), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8396), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8401), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8375), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8379), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8388), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8397), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8402), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8375), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8385), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8389), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8394), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8398), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8403), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8376), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8381), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8399), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8403), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8372), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8377), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8391), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8400), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8404), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5134), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.CreateIndex(
                name: "IX_Executors_UserId1",
                table: "Executors",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalServices_Approvers_ApproverId",
                table: "AdditionalServices",
                column: "ApproverId",
                principalTable: "Approvers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalServices_Executors_ExecutorId",
                table: "AdditionalServices",
                column: "ExecutorId",
                principalTable: "Executors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Approvers_AspNetUsers_UserId1",
                table: "Approvers",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalServices_Approvers_ApproverId",
                table: "AdditionalServices");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalServices_Executors_ExecutorId",
                table: "AdditionalServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Approvers_AspNetUsers_UserId1",
                table: "Approvers");

            migrationBuilder.DropTable(
                name: "Executors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Approvers",
                table: "Approvers");

            migrationBuilder.DropColumn(
                name: "InitialDateStop",
                table: "Colocations");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "ColocationHistories");

            migrationBuilder.RenameTable(
                name: "Approvers",
                newName: "Approver");

            migrationBuilder.RenameColumn(
                name: "ExecutorId",
                table: "AdditionalServices",
                newName: "ExecuterId");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalServices_ExecutorId",
                table: "AdditionalServices",
                newName: "IX_AdditionalServices_ExecuterId");

            migrationBuilder.RenameIndex(
                name: "IX_Approvers_UserId1",
                table: "Approver",
                newName: "IX_Approver_UserId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Approver",
                table: "Approver",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Executer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Executer_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3525), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3534), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3ece8ed-8dd6-4ff0-9c85-f30a0d4df8dc", "AQAAAAIAAYagAAAAEE+0RMDkjw+qj+CWbFiqN0HB7OK9NDt8dLmnDAddpPgexPFiAMvwd5KOqzJNgbphLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d65c3228-0f4d-46a8-a765-e66688fdeaab", "AQAAAAIAAYagAAAAECjBi/D/lNA1r8gBGqoIa0ANuy05K3rgv3QoLCTM5W4/C351RqDXqXD47wajscw96A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7750842d-2167-4653-919d-efb1205997ee", "AQAAAAIAAYagAAAAEGwGYjQLA1EN+JzSPodvQqyzN1iwpZCbtLC0M1gAviWvBHhTb1T5C4tJCMphoUrOBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f662e81-7e53-4cfd-8945-77cc94f5de30", "AQAAAAIAAYagAAAAEOAsTe5jcQMlBcj7F5V5MNR3EXLZV7N0T2+zBb+Oow6Pu0nXvEFWUjB293T4qdq0tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ec26252-cf80-465b-9d4b-b252d0fa1d24", "AQAAAAIAAYagAAAAEC0qC2aKchv8Su8wzpT5cCjjDgReCnsHeOliVP5kfQakbxfUnJ3QYDrEHjSA0biM5Q==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6278), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6366), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6375), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6385), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3503), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4388), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4392), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4399), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4402), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4412), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4416), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4419), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4422), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4425), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4429), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4435), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4446), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4449), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4452), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4465), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4476), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4483), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4486), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4489), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4498), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4505), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4508), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4512), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4515), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4518), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4524), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4531), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4537), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4543), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4547), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4550), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4553), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4556), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4569), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4572), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4591), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4594), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4613), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4622), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4635), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4638), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4641), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4661), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4664), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4667), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4677), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4683), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4686), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4693), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4696), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4699), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4702), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4734), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4737), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4740), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4747), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4750), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4753), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4756), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4759), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4762), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4765), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4768), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4772), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4781), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4784), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4793), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4796), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4800), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4809), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4812), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4815), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4834), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4837), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4843), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4846), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4849), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4852), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4855), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4858), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4871), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4874), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4877), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4896), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4912), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4915), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4918), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4921), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4924), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4928), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4931), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4934), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4949), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4952), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4955), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4958), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4961), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4965), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4968), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4971), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4974), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4977), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4980), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4983), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4986), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4989), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5009), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5015), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5018), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5021), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5024), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5031), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5043), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5047), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5050), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5056), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5059), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5062), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5072), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5078), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5088), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5091), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4324), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4348), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4356), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3541), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3582), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3590), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3605), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3612), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3619), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3548), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3583), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3592), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3599), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3606), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3613), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3620), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3584), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3593), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3600), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3607), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3614), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3576), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3586), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3594), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3601), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3577), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3587), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3594), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3609), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3616), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3630), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3588), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3595), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3610), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3631), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3580), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3596), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3603), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3611), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3581), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3597), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3604), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3612), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3634), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3640), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3696), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3701), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3705), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3709), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3718), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3636), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3641), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3697), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3701), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3706), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3710), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3719), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3637), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3642), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3698), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3702), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3707), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3711), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3715), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3720), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3648), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3699), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3703), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3712), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3716), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3721), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3649), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3700), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3704), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3713), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3717), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3722), new DateTime(2023, 10, 30, 11, 2, 4, 731, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6407), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6431), new DateTime(2023, 10, 30, 11, 2, 4, 363, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.CreateIndex(
                name: "IX_Executer_UserId1",
                table: "Executer",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalServices_Approver_ApproverId",
                table: "AdditionalServices",
                column: "ApproverId",
                principalTable: "Approver",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalServices_Executer_ExecuterId",
                table: "AdditionalServices",
                column: "ExecuterId",
                principalTable: "Executer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Approver_AspNetUsers_UserId1",
                table: "Approver",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
