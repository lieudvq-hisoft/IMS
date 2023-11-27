using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_host_status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2dfcd861-12be-47ca-af6e-8e0d4b9d1390", new DateTime(2023, 11, 28, 0, 1, 17, 192, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 11, 28, 0, 1, 17, 192, DateTimeKind.Local).AddTicks(5193), "AQAAAAIAAYagAAAAEEwLeNobt7h7y/SdThsRsbJGe3SGiO95G8DvPNiXamQg5189aoRmnNimV71Uz0v9AA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bb2e80a4-fee4-4a2d-bd2c-1ac92dd1de97", new DateTime(2023, 11, 28, 0, 1, 16, 925, DateTimeKind.Local).AddTicks(3821), new DateTime(2023, 11, 28, 0, 1, 16, 925, DateTimeKind.Local).AddTicks(3838), "AQAAAAIAAYagAAAAEDGpK+CzhYlKU+ybB8vyp17ryxn8UCqyDPv/76fkUEgWG0KaIZp6SyFavDVs+xXJBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "033b395d-0939-4f73-936f-52c1c2ed951c", new DateTime(2023, 11, 28, 0, 1, 17, 107, DateTimeKind.Local).AddTicks(7829), new DateTime(2023, 11, 28, 0, 1, 17, 107, DateTimeKind.Local).AddTicks(7851), "AQAAAAIAAYagAAAAEPp7LR+Bv5elsL04HIahGzppBmqizLCC6NlaKyHSKUvpJAeZJBMFHcI2raaiO1a5AQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3a5f79fe-3705-43f3-94ee-5830d63f747f", new DateTime(2023, 11, 28, 0, 1, 16, 719, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 11, 28, 0, 1, 16, 719, DateTimeKind.Local).AddTicks(536), "AQAAAAIAAYagAAAAEH0dlVis6IyuGq1gxeCpnDop+ftObPch+W/fS+Uy72FHiW+zJSnSP7bd2atOYgOTvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "70b90a0a-61d2-42e2-a42b-1f7e3108b399", new DateTime(2023, 11, 28, 0, 1, 16, 624, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 11, 28, 0, 1, 16, 624, DateTimeKind.Local).AddTicks(5093), "AQAAAAIAAYagAAAAEBUFZokr5/mb2pigv15EAwLItyzMfGuwB6G6yLQbHu2VP9LBJ+0n5/huB3LicphGFA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7638), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7649), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7685), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7729), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7878), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7925), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7926), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7933), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7941), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7903), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7919), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7927), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7934), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7942), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7884), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7895), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7928), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7943), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7896), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7921), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7929), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7936), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7944), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7897), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7913), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7922), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7929), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7937), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7898), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7907), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7923), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7946), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7899), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7924), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7931), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7939), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7946), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7948), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8025), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8036), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8046), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8021), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8026), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8042), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7951), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7957), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8022), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8028), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8038), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8043), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8048), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8023), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8029), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8034), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7953), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8019), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8024), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8030), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8035), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8050), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8050) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4065), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4081), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "169766f5-1e07-420c-8283-b02cb2f375f7", new DateTime(2023, 11, 27, 22, 27, 10, 542, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 11, 27, 22, 27, 10, 542, DateTimeKind.Local).AddTicks(1699), "AQAAAAIAAYagAAAAEKOH9e/06xyIWFBKsG1uTmYO2CmF8aNWyBpsTPwhVjwYtXEFp8KoQPk/JX0WPN+uhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "af0321ab-fd76-4530-bdbc-24f08e888c3e", new DateTime(2023, 11, 27, 22, 27, 10, 355, DateTimeKind.Local).AddTicks(8723), new DateTime(2023, 11, 27, 22, 27, 10, 355, DateTimeKind.Local).AddTicks(8736), "AQAAAAIAAYagAAAAEDNUNvsRKTQji/nCTLniSZG5yXTEMhDkf6b3wwFK1GvSL1I9eEgBlOZK1vddD/lzVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "541d3e01-1c89-401d-b57c-e65915111692", new DateTime(2023, 11, 27, 22, 27, 10, 438, DateTimeKind.Local).AddTicks(6459), new DateTime(2023, 11, 27, 22, 27, 10, 438, DateTimeKind.Local).AddTicks(6473), "AQAAAAIAAYagAAAAELqOBajBwOAG9N3sHjMW1Ozq0yfxif6NOLPUVnfqGJO82zEYAnTFE0bwJvkicKB8BA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "774bb7dc-2ce8-48bd-9c8c-816b72542268", new DateTime(2023, 11, 27, 22, 27, 10, 268, DateTimeKind.Local).AddTicks(7942), new DateTime(2023, 11, 27, 22, 27, 10, 268, DateTimeKind.Local).AddTicks(7954), "AQAAAAIAAYagAAAAED7G+L2I6oB69tBKvLiooTVLqToGzmcjVPD5zF5TjmF4RsibQj47q7UREQ1SE2s6pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6d10301a-8220-43a8-844f-56b8fbef2d8e", new DateTime(2023, 11, 27, 22, 27, 10, 188, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 27, 22, 27, 10, 188, DateTimeKind.Local).AddTicks(1542), "AQAAAAIAAYagAAAAEOlbIhSIzvua6S3tgOSPbSfTVzj7CuUTZeaVgxTiY/ptnYvpopOXJxpPdqxXT0H1jA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3802), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3905), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3917), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3928), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3995), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4023), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4036), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4006), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4145), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4159), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4167), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4184), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4207), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4150), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4161), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4169), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4177), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4185), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4208), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4151), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4162), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4178), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4186), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4202), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4209), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4152), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4171), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4187), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4153), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4172), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4180), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4196), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4211), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4164), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4173), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4181), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4189), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4197), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4165), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4174), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4182), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4205), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4166), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4222), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4275), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4284), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4261), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4266), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4271), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4281), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4285), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4219), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4262), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4267), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4281), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4286), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4220), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4263), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4268), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4277), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4282), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4226), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4269), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4274), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4279), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4283), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4288), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4289) });
        }
    }
}
