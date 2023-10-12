using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class status_enum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceStatus",
                table: "AdditionalServices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e08ad3d6-21cf-4208-8dcb-6d843791d366", "AQAAAAIAAYagAAAAEMrzJntb1J2LklUthS0rze+DUfbFXzLCwu2Nf7CtvWckyuhU9MieWmCBPqiNUJM18A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca4d1ca4-7d58-41d3-b430-cf13faa7c162", "AQAAAAIAAYagAAAAEG01VwNsXo64+Zfutx0tki/Wm3uUIAYa6ilAiA6mTZ/FJOUvhbM7yPSWpSFd/bIobA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1ccc721-7218-44c3-bce6-873ab97bb49f", "AQAAAAIAAYagAAAAEJZppUzkKa1Vi6WQmDaCEweOqsvPCqgsyLQsMU0lfHsxNf41LfM2SHCPHj2RJsJUxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80993697-f806-448b-bb26-6d3e3aec60d9", "AQAAAAIAAYagAAAAEAl14OkR3lcrfijNwUtxBa3NPcjjYVptzEdd8fS4A9ZSk8wGNljIk36jpnRuwImDvA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4056), new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4066), new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4073), new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4081), new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4110), new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4124), new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4132), new DateTime(2023, 10, 12, 22, 10, 53, 313, DateTimeKind.Local).AddTicks(4133) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceStatus",
                table: "AdditionalServices");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73c24578-5c42-42d7-ae1b-422b70498519", "AQAAAAIAAYagAAAAEFAnpx5QcN7HUzYGFjRYvK2kPaVdayG47OHLbWJ/zIz519vF3BKyZuQ+tK58JuVydQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1cde6a3-b1b6-4188-bd9a-9252c72402b4", "AQAAAAIAAYagAAAAEORgVmX3+vWmltxfELtm0tLUb1X1IwrtEGtwjgzwSslZRVH4KKOg1x1N3wg6rJ19ng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb3281db-b525-4669-9a38-44ac82bf4a14", "AQAAAAIAAYagAAAAEH1zX+xExkHk0snDI9PSMqXoswR1ADUc+cICx39VUUcLFCuPv7+3K4iAechhobBT4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7cadd2f7-44c4-4d1f-898b-cef6a6e0ff17", "AQAAAAIAAYagAAAAEKm3fOWBBDAhs02/t4qGIy8+1zFleMz3qvtN7pv0WuADcvL0HkOiZBvdOKvkQhrgew==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6544), new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6671), new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6709), new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6846), new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6901), new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6942), new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6988), new DateTime(2023, 10, 12, 21, 55, 38, 506, DateTimeKind.Local).AddTicks(6989) });
        }
    }
}
