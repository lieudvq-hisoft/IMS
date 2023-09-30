using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class seed_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "CurrenNoticeCount", "Email", "EmailConfirmed", "FcmToken", "FirstName", "Gender", "IdenficationConfirm", "IdenficationNumber", "IsGoogle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAva", "UserName", "isBlock", "isDelete" },
                values: new object[,]
                {
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), 0, "Address1", "21", "c97145ce-60e1-47a2-955d-2f8edb37dea6", 0, "member1@gmail.com", true, "token1", "FirstName1", false, true, "001183000001", true, "LastName1", false, null, "member1@gmail.com", "member1@gmail.com", "AQAAAAIAAYagAAAAEOGcikqM7agLYXSWWfDt5Ddcg6BRlkdHnRrcGbUguN32v9qn8LaleFD6ttcVwPevgQ==", null, false, "", false, "Avatar1", "user1", true, false },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 0, "Address2", "22", "8449d52e-57c2-4baf-b25a-ae7ee280659e", 0, "member2@gmail.com", true, "token2", "FirstName2", true, true, "001183000001", true, "LastName2", false, null, "member2@gmail.com", "member2@gmail.com", "AQAAAAIAAYagAAAAEEI9xDJhRzBxpV8oERBBjpWP8D9xf9k2RDASpQbMJ4mAc0fjYPJM20WkEIHP4GXjpQ==", null, false, "", false, "Avatar2", "user2", true, false },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), 0, "Address3", "23", "d95c418d-0cbc-4f03-ab7c-7311fc22d73a", 0, "member3@gmail.com", true, "token3", "FirstName3", false, true, "001183000001", true, "LastName3", false, null, "member3@gmail.com", "member3@gmail.com", "AQAAAAIAAYagAAAAEDzpO3bAiOjisGPxl8HX0+6ApFssGVOQcLhzhKjnawNYCvD7oDHD78UQqUBl7AqYmA==", null, false, "", false, "Avatar3", "user3", true, false },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), 0, "Address4", "24", "6ce317ea-8de6-4b02-bd8c-86285b5b6325", 0, "member4@gmail.com", true, "token4", "FirstName4", true, true, "001183000001", true, "LastName4", false, null, "member4@gmail.com", "member4@gmail.com", "AQAAAAIAAYagAAAAEJHyEwf9TrYBHBtU4sEcnHH5LD8Hh/XBVAberwVSpsMBClyWm6l0GytaPCfBLCDVDA==", null, false, "", false, "Avatar4", "user4", true, false },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), 0, "Address5", "25", "b9597df0-cda3-4c4a-8132-2b52e7859094", 0, "member5@gmail.com", true, "token5", "FirstName5", false, true, "001183000001", true, "LastName5", false, null, "member5@gmail.com", "member5@gmail.com", "AQAAAAIAAYagAAAAENby+i1ANY0zmg+tzK/Yiib+AavvPVzJbShSaSllmDLyymYx+aqCY13KqYIippNNFg==", null, false, "", false, "Avatar5", "user5", true, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"));
        }
    }
}
