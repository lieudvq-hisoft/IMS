using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class add_expected_size_to_collocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpectedSize",
                table: "Collocations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce601a38-fa62-4ce9-add1-44b0f793943d", "AQAAAAIAAYagAAAAEIszq9CrgpmEkGHbsxnxAsdozX3zu2SBzIuqgvtJKZLPPHaTgTEXKYIrqkCFF66COQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d88373eb-d146-443c-831a-674910a9fb14", "AQAAAAIAAYagAAAAEPtn8oLYDux9K+iir1asRJRuyHA8F+qDzZLS+19UGt/X7x7wtSDHauu4iMFr+yCnLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "743db8fb-f435-4021-ace0-9d1a72018f3e", "AQAAAAIAAYagAAAAEDr7csZjZ1f4pRy52eAuAETqOs78mM4IGb6coLEs9/+7My3zhcU8mB4IyRTn9VA2Tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93c0d0e1-9fd1-4595-ae61-70f2d095873e", "AQAAAAIAAYagAAAAEKFE+XRHBiGV3yJGEEWeKm5eRpp4Sy6XUJMY9EsqdcpM/B+wy0g3YvYBCVr7W1R3+g==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 10, 13, 14, 13, 30, 240, DateTimeKind.Local).AddTicks(8811) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpectedSize",
                table: "Collocations");

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
    }
}
