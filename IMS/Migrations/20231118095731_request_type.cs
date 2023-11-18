using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4633), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6df4e5ec-2dfd-42f7-b93e-9fdf182991f0", new DateTime(2023, 11, 18, 16, 57, 30, 950, DateTimeKind.Local).AddTicks(9201), new DateTime(2023, 11, 18, 16, 57, 30, 950, DateTimeKind.Local).AddTicks(9214), "AQAAAAIAAYagAAAAEOtS0TbcSEGnmMcCJi/9jiea49R8AdFLYLgkQMrHHG+cvm5VcE7y0OP52sjwxQOdtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "30fe9c37-b4c1-4c34-aa79-267e3eb325db", new DateTime(2023, 11, 18, 16, 57, 30, 807, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 11, 18, 16, 57, 30, 807, DateTimeKind.Local).AddTicks(1588), "AQAAAAIAAYagAAAAELRiYA12ikq0CcvJWLsViGdsgK7qOLPFwu9tIPJ+SKmuLPPFuXBSUw6MP2s4HkvEAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "117cb553-5f14-4e3c-9dc0-22ead36983a0", new DateTime(2023, 11, 18, 16, 57, 30, 881, DateTimeKind.Local).AddTicks(9581), new DateTime(2023, 11, 18, 16, 57, 30, 881, DateTimeKind.Local).AddTicks(9591), "AQAAAAIAAYagAAAAEE7uF7DMBnC2nA+QSSsAyGEHBM1QP3FI7yF8zUJxOhQP4aeCmJmk/QjvM7ocJXQQOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "686a92c4-b24a-47e5-87c9-8d2a313ab29d", new DateTime(2023, 11, 18, 16, 57, 30, 729, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 11, 18, 16, 57, 30, 729, DateTimeKind.Local).AddTicks(2872), "AQAAAAIAAYagAAAAEIUs/R5q1Je4kDLTSD462yAMQ24GVqCWmnO0WSG8yI1HfBETZQoJgyCBE7RyTcDMKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "79cd7e09-5a8b-4538-9363-991acb6932b5", new DateTime(2023, 11, 18, 16, 57, 30, 654, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 11, 18, 16, 57, 30, 654, DateTimeKind.Local).AddTicks(3207), "AQAAAAIAAYagAAAAED1qfV3hVPOHlNkgi72+JDRKypUSH3vF/kf3A/pdJq0Kwez17GqhBlnNi63qUC3+wg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4334), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4418), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4444), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4535), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4577), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4592), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4564), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4651), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4677), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4686), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4695), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4703), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4711), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4719), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4726), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4656), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4679), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4688), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4696), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4704), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4712), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4689), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4697), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4713), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4789), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4681), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4698), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4706), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4714), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4721), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4672), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4682), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4691), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4699), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4707), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4715), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4722), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4791), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4683), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4692), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4699), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4708), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4792), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4675), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4693), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4709), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4717), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4724), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4793), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4694), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4702), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4718), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4725), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4794), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4802), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4808), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4813), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4823), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4798), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4809), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4824), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4833), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4799), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4805), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4834), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4800), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4811), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4815), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4820), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4826), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4801), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4807), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4811), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 11, 18, 16, 57, 30, 649, DateTimeKind.Local).AddTicks(4837) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6395), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6414), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6b824d23-53db-4e0e-bdfb-a2320027bba8", new DateTime(2023, 11, 18, 16, 32, 56, 478, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 11, 18, 16, 32, 56, 478, DateTimeKind.Local).AddTicks(5983), "AQAAAAIAAYagAAAAEM+hBbRjMvDOu6KGKXQS6tV0DQMnLhf3aDmdrTxCbvGMk9O5yujmp0doVF68CWUlRQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "244afe47-5fef-40a0-933e-e379d71b8748", new DateTime(2023, 11, 18, 16, 32, 56, 320, DateTimeKind.Local).AddTicks(6016), new DateTime(2023, 11, 18, 16, 32, 56, 320, DateTimeKind.Local).AddTicks(6028), "AQAAAAIAAYagAAAAEAIpwejI+Jc7v2j8C1SzsypJHxOPKLBJ+zHvWIvqkdhagORF645TFP8KwV+HqkK5hA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "419b087f-da08-412b-bb0f-10600a7e8022", new DateTime(2023, 11, 18, 16, 32, 56, 398, DateTimeKind.Local).AddTicks(2254), new DateTime(2023, 11, 18, 16, 32, 56, 398, DateTimeKind.Local).AddTicks(2265), "AQAAAAIAAYagAAAAEOWDFvW+DnzoioIJGC/9q725DH8uyEP6FkL6Tx9jJ+uLENEJxCvzadHJRKGnAfNLzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ef9f9050-daa5-43dc-9134-80f1cffdace5", new DateTime(2023, 11, 18, 16, 32, 56, 250, DateTimeKind.Local).AddTicks(146), new DateTime(2023, 11, 18, 16, 32, 56, 250, DateTimeKind.Local).AddTicks(160), "AQAAAAIAAYagAAAAEFcFO7ZN3MDv+2T+h5uzhLtc0wQ1LCHx4gYkFG8cMW2c7iUv3DYCw/ZwURKziDaruw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "dba79aaf-baba-4460-a7ec-43d78f61ad2b", new DateTime(2023, 11, 18, 16, 32, 56, 174, DateTimeKind.Local).AddTicks(3184), new DateTime(2023, 11, 18, 16, 32, 56, 174, DateTimeKind.Local).AddTicks(3196), "AQAAAAIAAYagAAAAELsucVtjkfRNDwILkVTAjrKIosid5qwBAsD4YynmAPf+GI6vBfUxtv1JZUPHyEd7ig==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6152), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6223), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6287), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6452), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6461), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6469), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6478), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6486), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6494), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6502), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6442), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6479), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6487), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6495), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6503), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6444), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6464), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6471), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6488), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6496), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6445), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6456), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6465), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6472), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6481), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6489), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6497), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6446), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6473), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6482), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6498), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6506), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6448), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6458), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6475), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6483), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6491), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6499), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6518), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6459), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6467), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6475), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6484), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6492), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6519), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6451), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6468), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6476), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6493), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6501), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6520), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6521), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6528), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6533), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6538), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6543), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6548), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6553), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6558), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6523), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6529), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6534), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6539), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6544), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6549), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6524), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6530), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6535), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6545), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6555), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6525), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6531), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6536), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6541), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6551), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6556), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6561), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6527), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6537), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6542), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6547), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6552), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6557), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6562), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6562) });
        }
    }
}
