using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class seed_role : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "isDeactive" },
                values: new object[,]
                {
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), null, "Customer", "Customer", null, false },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), null, "IT Staff", "IT", null, false },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), null, "Staff", "Staff", null, false },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), null, "Manager", "Manager", null, false },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), null, "Admin", "Admin", null, false }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fd4bd5e-a2eb-4d67-a651-8007e8d7ff12", "AQAAAAIAAYagAAAAEOgvmD9SMN1iSWn0hq3HppVUxZu0KVqvtQzjthfFTbgpR75Q6qyuvdCn9pxtVIWSOQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78fab7eb-987a-45b1-8514-43d0a5366421", "AQAAAAIAAYagAAAAEILXRvlHgT1k+kH7RQf2m9msyb4JamN6UJ0CqFq/pSoRcJven7qtmdzlDpdZoOIWRQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ac8c526-d3e0-4bff-8205-830860994d50", "AQAAAAIAAYagAAAAEFC7OmboX8roYX/mwnT3rL3VggyTUR+E/dwH/KEvRpSWGu672O95rBW74+nofQgS9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3dc335a2-7988-4c99-92a6-ee50e6423f7d", "AQAAAAIAAYagAAAAEI9yQL7+69r0x12jUtYmFynGfwowEBOQF135UeNpigJPoWuCgsLDV11h7F/RVPyLIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c3e34c4-7b8e-4dbf-b85f-118afb242587", "AQAAAAIAAYagAAAAEJzun7bk+ei4RcVltKdIfTH3uiqM4TdO8JSyte+Y693u2BkItzO5a90wp+Z9FmL0nQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4") },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd") },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba") },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c97145ce-60e1-47a2-955d-2f8edb37dea6", "AQAAAAIAAYagAAAAEOGcikqM7agLYXSWWfDt5Ddcg6BRlkdHnRrcGbUguN32v9qn8LaleFD6ttcVwPevgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8449d52e-57c2-4baf-b25a-ae7ee280659e", "AQAAAAIAAYagAAAAEEI9xDJhRzBxpV8oERBBjpWP8D9xf9k2RDASpQbMJ4mAc0fjYPJM20WkEIHP4GXjpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d95c418d-0cbc-4f03-ab7c-7311fc22d73a", "AQAAAAIAAYagAAAAEDzpO3bAiOjisGPxl8HX0+6ApFssGVOQcLhzhKjnawNYCvD7oDHD78UQqUBl7AqYmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ce317ea-8de6-4b02-bd8c-86285b5b6325", "AQAAAAIAAYagAAAAEJHyEwf9TrYBHBtU4sEcnHH5LD8Hh/XBVAberwVSpsMBClyWm6l0GytaPCfBLCDVDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9597df0-cda3-4c4a-8132-2b52e7859094", "AQAAAAIAAYagAAAAENby+i1ANY0zmg+tzK/Yiib+AavvPVzJbShSaSllmDLyymYx+aqCY13KqYIippNNFg==" });
        }
    }
}
