using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_user_and_customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyRepresentative",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "FcmToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "AspNetUsers",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "Fullname");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "ConcurrencyStamp", "Fullname", "PasswordHash" },
                values: new object[] { "2cdf8928-7d8c-485c-bb7b-bd16688753b2", "Fullname1", "AQAAAAIAAYagAAAAEOLr4jWsWPKBzxOifNDHbvQYPijWnmRGR0Zi2nnXa7ZkojfLTqkvKGJOeINX/XAybA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "Fullname", "PasswordHash" },
                values: new object[] { "afd904dd-8799-401c-aa32-561039f3e59f", "Fullname2", "AQAAAAIAAYagAAAAEAZSz+nGVsLk5/OzI5lUyNx5ZX0TpteUwE4IDJOw0ewXU5SfKKW4OgwGXcvokX7q9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "Fullname", "PasswordHash" },
                values: new object[] { "cd4af860-7705-4134-ac5f-f05a2c1bc39d", "Fullname3", "AQAAAAIAAYagAAAAEKlLowcqYENSICm/SD7a4XUr1+KadQV9KW8/aGfyOqhAruTCYPQD3ce6f10rx5qmnw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "Fullname", "PasswordHash" },
                values: new object[] { "1f7af214-be59-4705-bb8f-182ededd4cd8", "Fullname4", "AQAAAAIAAYagAAAAEBV6OJnI6ydosHn+KLKG4sfPzAyETqT0klZ+p5zJSfza3wCeECVuImhVV6x+lHx4gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "Fullname", "PasswordHash" },
                values: new object[] { "bdf362f5-8366-4529-98c2-44ac2a81e674", "Fullname5", "AQAAAAIAAYagAAAAEIkgEobSJxfO30NbfykBu8MljbZGuMMvdauPuBMbAaTZQTyMf4aSlqXdeUUP2gCowQ==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 4, 21, 28, 33, 143, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 10, 4, 21, 28, 33, 143, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 4, 21, 28, 33, 143, DateTimeKind.Local).AddTicks(4493), new DateTime(2023, 10, 4, 21, 28, 33, 143, DateTimeKind.Local).AddTicks(4493) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "AspNetUsers",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "CompanyRepresentative",
                table: "Customer",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FcmToken",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "varchar(1000)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "ConcurrencyStamp", "FcmToken", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "31f384dd-65c3-4bf4-b9c4-c132c66073fb", "token1", "FirstName1", "LastName1", "AQAAAAIAAYagAAAAEMpcYGyosp3r+G2TuClqfic+iG+661RlhWQSoe2bqqREIG6KsRKvbbu/rT+rTsTD0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "FcmToken", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "4d70424d-73cb-4cf2-b62d-a2182dd67bec", "token2", "FirstName2", "LastName2", "AQAAAAIAAYagAAAAEJBWtFFK7JqnuwcQlOdbLSvUIQgGhheN2XRgC6Sq0L8zqgw3rV5K8WT5uMP2/5PEMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "FcmToken", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "d24a4f7e-7544-48ba-a0da-c191e574b820", "token3", "FirstName3", "LastName3", "AQAAAAIAAYagAAAAEFAJ38spWreI4RAoR2e5vjAorz/WnzhXAbNyMQVYLH/TTNdybhZwmmK+/uUn1J7E7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "FcmToken", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "859742a4-c66c-4e97-bb07-80c3ca69fad8", "token4", "FirstName4", "LastName4", "AQAAAAIAAYagAAAAECdlzvAi68nNVHjV8yzGDyqkKAKjsl8OtHR8ozYmt8l/OXD84DaTVOpLToAqddrGCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "FcmToken", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { "d6674f92-e3d8-45e3-b995-9c7315734499", "token5", "FirstName5", "LastName5", "AQAAAAIAAYagAAAAEPdou0YA5yyKRLhIyHC2WVzSVlh/+dAlLeFX77JqkwxrsedBP/EDBYLpY9yeoYOv8Q==" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyRepresentative", "DateCreated", "DateUpdated" },
                values: new object[] { "Representative 1", new DateTime(2023, 10, 3, 13, 25, 22, 726, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 10, 3, 13, 25, 22, 726, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyRepresentative", "DateCreated", "DateUpdated" },
                values: new object[] { "Representative 2", new DateTime(2023, 10, 3, 13, 25, 22, 726, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 10, 3, 13, 25, 22, 726, DateTimeKind.Local).AddTicks(465) });
        }
    }
}
