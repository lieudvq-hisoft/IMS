using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class add_date_manage_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8d3f553e-f05f-4175-bcb2-c58bcda45494", new DateTime(2023, 11, 13, 17, 50, 47, 669, DateTimeKind.Local).AddTicks(8354), new DateTime(2023, 11, 13, 17, 50, 47, 669, DateTimeKind.Local).AddTicks(8367), "AQAAAAIAAYagAAAAEIzVTZ/nOuyrG1ESf3YvLgxTzJFEYurS3XxA4Q+2/OuHG/RTEv/vJVV6fjGtSKHK0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "cf2591ae-9b8c-4afb-8ebc-f550f7233513", new DateTime(2023, 11, 13, 17, 50, 47, 474, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 11, 13, 17, 50, 47, 474, DateTimeKind.Local).AddTicks(6417), "AQAAAAIAAYagAAAAEEwKiXXCUBiIr8RK9eN75Ea88oXrkQrC83J9iejC0LU6Fs0UsRBIjVavp2c+6z5fwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2d646f42-fd40-41ac-83f7-9beb43b7edb0", new DateTime(2023, 11, 13, 17, 50, 47, 591, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 11, 13, 17, 50, 47, 591, DateTimeKind.Local).AddTicks(3112), "AQAAAAIAAYagAAAAECXP/4dwHRu332QkOq4SY3odynZVaJGHrK4OpgEq6ujUBbJ/Ts5J4hNpFIONPt/MXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "eb2aac8f-2107-45e5-a521-1429ebfb2958", new DateTime(2023, 11, 13, 17, 50, 47, 398, DateTimeKind.Local).AddTicks(2232), new DateTime(2023, 11, 13, 17, 50, 47, 398, DateTimeKind.Local).AddTicks(2264), "AQAAAAIAAYagAAAAELtyKTMUDf+AlMe2odrcOWHg8pX8Q9vg3dD/mu3Wa+L9BlmUBcjzYsBNDMhDRQP2PA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1734a571-57b2-4d50-8efc-b30a6ee71cf7", new DateTime(2023, 11, 13, 17, 50, 47, 320, DateTimeKind.Local).AddTicks(134), new DateTime(2023, 11, 13, 17, 50, 47, 320, DateTimeKind.Local).AddTicks(134), "AQAAAAIAAYagAAAAEHG6IQkzlvosX6gg3DA07EYO55t3OGFIKkZM+E3sbhjVMlptlREbB5A4nwCPbcZEfA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9840), new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9850), new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9861), new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9894), new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9982), new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9997), new DateTime(2023, 11, 13, 17, 50, 47, 319, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 320, DateTimeKind.Local).AddTicks(21), new DateTime(2023, 11, 13, 17, 50, 47, 320, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 320, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 11, 13, 17, 50, 47, 320, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 50, 47, 320, DateTimeKind.Local).AddTicks(8), new DateTime(2023, 11, 13, 17, 50, 47, 320, DateTimeKind.Local).AddTicks(9) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9f38c47-0850-4649-b1bf-ed3224f268c8", "AQAAAAIAAYagAAAAEH3SDLhiGX3mCo81cXvi2R1qZSoUIVGA1ecDgMyPTvnybExm0UUUTHJ16bfN0hutVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "797f7e72-4556-47de-ab0f-761c3ec816a3", "AQAAAAIAAYagAAAAEKne845RBhA9fR05VUvwXJMnKC/ORlB28pFgkh4DY+9uP7LbK6kh6J4wuLGnHLX+rQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3abae10-1d32-4186-889c-b62faf3b9752", "AQAAAAIAAYagAAAAEIuVLVEr3LedXl6xVuBMHBafm/u5jHVztdp0xop9ws1PaB5kN4tZXlW2BcTi/SHw5Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09aab686-b636-4bc9-bcca-725bee45cda8", "AQAAAAIAAYagAAAAEP1zbuWH1O/5jz8UhaSKkBNRAVPmQYHXZ+Qh0sNxfrIkvwtgMI4zxbmzwwuh76DE3Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c0d5f15-6448-4426-856d-ff7be93121a7", "AQAAAAIAAYagAAAAEAMwbfAzatsF+fmfyk0Svr1AHBMn3H+ct/KK6gLdOlmAll5QG6P8lbbwLbrZ9c91CQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8051), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8091), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8123), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8147), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8176), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8187), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8208), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8218), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8196), new DateTime(2023, 11, 13, 10, 46, 12, 391, DateTimeKind.Local).AddTicks(8197) });
        }
    }
}
