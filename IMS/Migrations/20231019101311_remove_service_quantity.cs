using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class remove_service_quantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "AdditionalServices");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2496), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16eba310-335f-4c15-8065-e892c95f6e94", "AQAAAAIAAYagAAAAEG/DtW4rHsWyVp7RsVHB1RxBteizFEbX9SN22zw3rTilSxGFOiBC/8oAHxzUp1jymg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6de3d884-cfda-42dd-9d5d-1ed1c4acc3ef", "AQAAAAIAAYagAAAAEEeeUZ8UMjn1lC88t/R35cLBoMX9kVzRnBVRAS4Ap6tXl4LRqAKDaghAwcKb1i7DRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f30fdce0-81e8-4618-b308-efe2e394eade", "AQAAAAIAAYagAAAAED+VouIz6KM3DDTJBuqbSKqzbjDi1adEcnuNL4EWnbA5o1vAN4fSwjrjfAfjlnC34g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d90f3c38-efab-467e-9fe0-bea70d888544", "AQAAAAIAAYagAAAAEIUdqGIg8G0G5DUIayGCayREy1WreRi+ewr//duTWsPB/XSWpSBtyuruhViP7ETjnA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4427), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4658), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2462), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3338), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2518), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2528), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2716), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2666), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2787), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2845), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2554), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2673), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2701), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2794), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2821), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2648), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2676), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2797), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2852), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2999), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3085), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3102), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3274), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3004), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3089), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3122), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3277), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3041), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3109), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3126), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3045), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3129), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3267), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3284), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3031), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3081), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3099), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3271), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3287), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4746), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4782), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4820) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "AdditionalServices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6657), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d67c0bee-5b14-46cb-a38e-da1b168d8394", "AQAAAAIAAYagAAAAEHhhl4yEg9dC0BS2rTjxPL9D/bNBfQl/WqRe6ZBLL2bgLC1tbb4SU1t4qtt5/iWLDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b01c2fb-860b-4b35-a3d7-45fb4566964b", "AQAAAAIAAYagAAAAEHvPxpUwoRDtZW/ewa8Y20yMaftUYLoGk7xC2kJjgRMNM5BX4y76wpuPMY6clFxSzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5af17958-0e78-48ca-b5ba-a4b58596f5b2", "AQAAAAIAAYagAAAAEI1oEHkN6MRJ4LECFhl1aDcxkhxRfOTR4QNdnTSbFq8XhJAwDMxX+2bBcg6k/DevgA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a70e911a-ec42-4db3-b3d7-fccf5984bf1f", "AQAAAAIAAYagAAAAEDyVklwD+c4hkXZSbaTzPr/q+5NCC32G9/V7up5e9WITFLH4rhTniD2FSXpTfm9KqQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(345), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7663), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6672), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6724), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6765), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6895), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6935), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7114), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7153), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6683), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6771), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6901), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6940), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7119), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7158), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6688), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7123), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7163), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6781), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6911), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7039), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7128), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7168), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6699), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6746), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6786), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6916), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7044), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7132), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7173), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6710), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6751), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6791), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6921), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7049), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7137), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7178), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6715), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6926), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7054), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7142), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7184), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6719), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6850), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6889), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7107), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7147), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7189), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7195), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7222), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7292), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7342), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7365), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7631), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7203), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7321), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7346), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7636), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7207), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7279), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7302), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7326), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7375), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7640), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7212), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7284), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7307), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7621), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7644), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7217), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7311), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7336), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7384), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7626), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7649), new DateTime(2023, 10, 19, 17, 2, 24, 536, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(520), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(531), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(539), new DateTime(2023, 10, 19, 17, 2, 24, 213, DateTimeKind.Local).AddTicks(540) });
        }
    }
}
