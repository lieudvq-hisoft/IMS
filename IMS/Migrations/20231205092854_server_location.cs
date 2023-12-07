using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class server_location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServerLocation",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3774), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3788), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4585431d-025f-4a1b-aa7b-82b64d17acca", new DateTime(2023, 12, 5, 16, 28, 53, 31, DateTimeKind.Local).AddTicks(3998), new DateTime(2023, 12, 5, 16, 28, 53, 31, DateTimeKind.Local).AddTicks(4010), "AQAAAAIAAYagAAAAELcmhsg7VxDlblfNRRwvn+65csCcB0iH/He4HwMOxToompdE5dzHOadPbW3QDizSew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c469187c-7029-4de4-acb3-ae0dca1c3899", new DateTime(2023, 12, 5, 16, 28, 52, 869, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 12, 5, 16, 28, 52, 869, DateTimeKind.Local).AddTicks(2781), "AQAAAAIAAYagAAAAED/jrzfT7oQXIf4x5JNgL5iQEaTrmKFSfhC2qVVfCnLI1yTqxqKwWXYxkmQpaHq4lQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "eff9ee36-19e9-4307-957c-e5f9ae190ec8", new DateTime(2023, 12, 5, 16, 28, 52, 948, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 12, 5, 16, 28, 52, 948, DateTimeKind.Local).AddTicks(7332), "AQAAAAIAAYagAAAAEKB18ftcronzYHRYsXr/u8SKI7jaTlSQtgovWiwN6DdmaK+zc1Wquk3M1fdk+AEiXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8325e394-40db-4038-bf92-f919e3ebc4d5", new DateTime(2023, 12, 5, 16, 28, 52, 788, DateTimeKind.Local).AddTicks(3867), new DateTime(2023, 12, 5, 16, 28, 52, 788, DateTimeKind.Local).AddTicks(3879), "AQAAAAIAAYagAAAAECIb4+Gp3iJjtnvaxlw3e20Hikb7NzK8EMh1U04mCzYlB5MfZOZ02okCsvVvlxoFyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "5749a0bd-8f6b-4477-8d85-bf7491ce847e", new DateTime(2023, 12, 5, 16, 28, 52, 719, DateTimeKind.Local).AddTicks(7021), new DateTime(2023, 12, 5, 16, 28, 52, 719, DateTimeKind.Local).AddTicks(7028), "AQAAAAIAAYagAAAAEB5363bHv3e7aloYkJxRreXZWgdKFBLaIwz7t79P+Cfh+sGxVzCVDMrv8AQ9lrQIFQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3596), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3721), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3731), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3742), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3753), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3816), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3857), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3866), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3875), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3883), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3892), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3943), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3951), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3828), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3859), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3868), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3876), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3885), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3893), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3944), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3829), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3860), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3869), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3877), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3886), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3894), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3945), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3837), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3861), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3870), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3878), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3887), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3895), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3946), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3838), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3862), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3871), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3879), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3896), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3947), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3854), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3863), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3872), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3880), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3889), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3948), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3955), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3864), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3873), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3881), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3890), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3940), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3949), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3956), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3856), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3865), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3874), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3882), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3891), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3941), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3949), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3957), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3959), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3965), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3975), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3984), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3989), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3961), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3966), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3971), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3976), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3985), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3995), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3962), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3972), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3981), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3986), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3996), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3963), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3968), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3973), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3978), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3964), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3969), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3974), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3978), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3988), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3993), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3998), new DateTime(2023, 12, 5, 16, 28, 52, 715, DateTimeKind.Local).AddTicks(3998) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServerLocation",
                table: "ServerAllocations");

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
    }
}
