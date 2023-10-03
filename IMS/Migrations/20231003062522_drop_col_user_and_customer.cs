using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class drop_col_user_and_customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdenficationConfirm",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdenficationNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsGoogle",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "isBlock",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31f384dd-65c3-4bf4-b9c4-c132c66073fb", "AQAAAAIAAYagAAAAEMpcYGyosp3r+G2TuClqfic+iG+661RlhWQSoe2bqqREIG6KsRKvbbu/rT+rTsTD0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d70424d-73cb-4cf2-b62d-a2182dd67bec", "AQAAAAIAAYagAAAAEJBWtFFK7JqnuwcQlOdbLSvUIQgGhheN2XRgC6Sq0L8zqgw3rV5K8WT5uMP2/5PEMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d24a4f7e-7544-48ba-a0da-c191e574b820", "AQAAAAIAAYagAAAAEFAJ38spWreI4RAoR2e5vjAorz/WnzhXAbNyMQVYLH/TTNdybhZwmmK+/uUn1J7E7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "859742a4-c66c-4e97-bb07-80c3ca69fad8", "AQAAAAIAAYagAAAAECdlzvAi68nNVHjV8yzGDyqkKAKjsl8OtHR8ozYmt8l/OXD84DaTVOpLToAqddrGCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6674f92-e3d8-45e3-b995-9c7315734499", "AQAAAAIAAYagAAAAEPdou0YA5yyKRLhIyHC2WVzSVlh/+dAlLeFX77JqkwxrsedBP/EDBYLpY9yeoYOv8Q==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 3, 13, 25, 22, 726, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 10, 3, 13, 25, 22, 726, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 3, 13, 25, 22, 726, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 10, 3, 13, 25, 22, 726, DateTimeKind.Local).AddTicks(465) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IdenficationConfirm",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "IdenficationNumber",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsGoogle",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isBlock",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "ConcurrencyStamp", "IdenficationConfirm", "IdenficationNumber", "IsGoogle", "PasswordHash", "isBlock" },
                values: new object[] { "b5837b6f-1666-49a1-8786-edb8371605e8", true, "001183000001", true, "AQAAAAIAAYagAAAAEErRI5CK7VIzGmcB716uttKgp6yEFY7a2ndbO+Syzl8Yob+tRLSIEB7aLBS6m+3Uxw==", true });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "IdenficationConfirm", "IdenficationNumber", "IsGoogle", "PasswordHash", "isBlock" },
                values: new object[] { "288ec5da-4893-491b-a510-7d18d8b1f880", true, "001183000001", true, "AQAAAAIAAYagAAAAEGqe9EWHHhvKfDv7HReFyW1gPNnWvLyFBf9tZgqvuWhH4EDeRQlrchTyptyUZIxB6A==", true });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "IdenficationConfirm", "IdenficationNumber", "IsGoogle", "PasswordHash", "isBlock" },
                values: new object[] { "1b45bf0d-e553-4b53-a0c9-f16926ba5e4d", true, "001183000001", true, "AQAAAAIAAYagAAAAEPDh/SJATdIpFYKdcJ862CIlUgMrdTNZzMo6Vh3bK/XKxnM+Sun/7jYG96NBvJmiiw==", true });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "IdenficationConfirm", "IdenficationNumber", "IsGoogle", "PasswordHash", "isBlock" },
                values: new object[] { "0bf22c75-ce4a-431a-8802-624b183c9590", true, "001183000001", true, "AQAAAAIAAYagAAAAEDdoSBTeS3aogN8JNwbNtl/FPx5yr3LB987Xc9ZA53rJVBlVok/qGDdyzAN/xBoBRw==", true });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "IdenficationConfirm", "IdenficationNumber", "IsGoogle", "PasswordHash", "isBlock" },
                values: new object[] { "b362f201-ac02-4e2c-9218-a55ebdf624d9", true, "001183000001", true, "AQAAAAIAAYagAAAAEM92jm9HOXdwQ7PUucL5a9renYmpSimMYf0Vs02Mv0fCCCtGcDMldU5db0jw+fZdhg==", true });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 2, 23, 41, 54, 74, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 10, 2, 23, 41, 54, 74, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 2, 23, 41, 54, 74, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 10, 2, 23, 41, 54, 74, DateTimeKind.Local).AddTicks(5821) });
        }
    }
}
