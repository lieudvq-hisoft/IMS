using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class undo_seed_customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d855491-c92f-44a0-895f-846e9dbc1b06", "AQAAAAIAAYagAAAAEP6Mu58sqfRDKpsC8z2zHezvrA2Dru+Xg806/JtFEQn4KzGL5T0dBvqHRpmQg2tVcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "440cd3e6-a9fc-4f48-b13a-c4b2350cbb17", "AQAAAAIAAYagAAAAENGyAyulfcG6ZnnFZ11WVlajj1sY+v3dhXrfjHQaQ9x3lEcIcZRFreSFmL5/8O5T5Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bd769a6-f71d-48cb-99da-ba7c5ad830ad", "AQAAAAIAAYagAAAAEFjm+ZZQsHEEkLQgKIRunlX5eCbXHYNrxcoCtCM+fpZ8UxJ/eSz8Ilk++mbv0EUk6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7be5590-f73d-4c07-a4e0-fc29ecdd0885", "AQAAAAIAAYagAAAAEF+x6VFdjY4eE/lE+cl2KUUCBEhbjdM9Jql4ONfhgCVvd/8LxKEGEfLKuy0QntG/Pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53909117-3d34-45c2-80bd-33249a4874e0", "AQAAAAIAAYagAAAAEGryF3YReBj4BkPB20bUrgUDwXEEum8gqrHrKRU7ndH4wH3CSsW8gVvNXJ9FZWobeQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2cdf8928-7d8c-485c-bb7b-bd16688753b2", "AQAAAAIAAYagAAAAEOLr4jWsWPKBzxOifNDHbvQYPijWnmRGR0Zi2nnXa7ZkojfLTqkvKGJOeINX/XAybA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afd904dd-8799-401c-aa32-561039f3e59f", "AQAAAAIAAYagAAAAEAZSz+nGVsLk5/OzI5lUyNx5ZX0TpteUwE4IDJOw0ewXU5SfKKW4OgwGXcvokX7q9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd4af860-7705-4134-ac5f-f05a2c1bc39d", "AQAAAAIAAYagAAAAEKlLowcqYENSICm/SD7a4XUr1+KadQV9KW8/aGfyOqhAruTCYPQD3ce6f10rx5qmnw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f7af214-be59-4705-bb8f-182ededd4cd8", "AQAAAAIAAYagAAAAEBV6OJnI6ydosHn+KLKG4sfPzAyETqT0klZ+p5zJSfza3wCeECVuImhVV6x+lHx4gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bdf362f5-8366-4529-98c2-44ac2a81e674", "AQAAAAIAAYagAAAAEIkgEobSJxfO30NbfykBu8MljbZGuMMvdauPuBMbAaTZQTyMf4aSlqXdeUUP2gCowQ==" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CompanyName", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "Company 1", new DateTime(2023, 10, 4, 21, 28, 33, 143, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 10, 4, 21, 28, 33, 143, DateTimeKind.Local).AddTicks(4421), false, "taxnumber1", new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4") },
                    { 2, "Company 2", new DateTime(2023, 10, 4, 21, 28, 33, 143, DateTimeKind.Local).AddTicks(4493), new DateTime(2023, 10, 4, 21, 28, 33, 143, DateTimeKind.Local).AddTicks(4493), false, "taxnumber2", new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") }
                });
        }
    }
}
