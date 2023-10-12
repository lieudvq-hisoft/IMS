using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_field_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceStatus",
                table: "AdditionalServices",
                newName: "Status");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6304cdd3-2260-4844-b56c-bd619a6c45df", "AQAAAAIAAYagAAAAECVNR7FKlePPFSENtIe8t5qEmq957VwruU+NbWMcbqWQnyisW4wJO1VTjPPtdks9wQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c358f97b-d192-491f-aa0b-54c9a8a79c68", "AQAAAAIAAYagAAAAEI4xK+szRbFkzE+8ptwY/66s/yR7g3Hc1T2Za9sppJ2M0GqSfaOjmdICKF2lKmeJ/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5c6a5e9-1884-4559-8070-82a056578787", "AQAAAAIAAYagAAAAENV7Oso+IVBWOAqzD66wQp+tCoSePA6J5V2Qnx+rT3LQaQijD4x0NvhPrSINGBtFmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29d45fb8-3b65-4da3-90c7-4dd5d646aa1f", "AQAAAAIAAYagAAAAEFaojBKgmRmBxna8dOcc614kynbkRP2zHjmiJOk2XogrMKy9bWMiTxNEAjRVItuMlg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7451), new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7509), new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7523), new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7536), new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7589), new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7617), new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7652), new DateTime(2023, 10, 12, 22, 15, 4, 667, DateTimeKind.Local).AddTicks(7653) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "AdditionalServices",
                newName: "ServiceStatus");

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
    }
}
