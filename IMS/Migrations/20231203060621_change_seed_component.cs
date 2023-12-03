using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_seed_component : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2875), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "042eec40-b6d6-44d5-b7e3-811ae2724f54", new DateTime(2023, 12, 3, 13, 6, 20, 900, DateTimeKind.Local).AddTicks(2676), new DateTime(2023, 12, 3, 13, 6, 20, 900, DateTimeKind.Local).AddTicks(2687), "AQAAAAIAAYagAAAAEOKped3KF0p7rnjFTlNzNGPjoVqKT/qdNJZ2ri1H6e/i89CTY9zlOLxwILWwusqpWA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "58046b51-f59f-4211-9f7e-db689ccc6299", new DateTime(2023, 12, 3, 13, 6, 20, 749, DateTimeKind.Local).AddTicks(1390), new DateTime(2023, 12, 3, 13, 6, 20, 749, DateTimeKind.Local).AddTicks(1401), "AQAAAAIAAYagAAAAEEFA0pHkc0EjQJixsxoPFgxiPX7Ygg/u6CPssESknRIsGaWgdgxf9kEH8dmhxKsmWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "75853a8d-2e6f-4050-a8a7-798b564983cf", new DateTime(2023, 12, 3, 13, 6, 20, 826, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 12, 3, 13, 6, 20, 826, DateTimeKind.Local).AddTicks(444), "AQAAAAIAAYagAAAAEImhhbhNH+TCaICwwVF5NeRavdaZTQVQTfgX8WpVhpiQyt3nc5qjfm27jotVMntEMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a51230db-8d55-4732-b6eb-340fcbc80989", new DateTime(2023, 12, 3, 13, 6, 20, 673, DateTimeKind.Local).AddTicks(6873), new DateTime(2023, 12, 3, 13, 6, 20, 673, DateTimeKind.Local).AddTicks(6883), "AQAAAAIAAYagAAAAEOqng77v/xkNfj3DRTNwfllg6YjT4olI1vpCVcbhuIsPpF9fqzA8SyPTe1e7NO9ZXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "29829425-8245-4cb4-9d18-b10abd3187dd", new DateTime(2023, 12, 3, 13, 6, 20, 602, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 12, 3, 13, 6, 20, 602, DateTimeKind.Local).AddTicks(5930), "AQAAAAIAAYagAAAAEFuwFFRH9L3RbOApN9cx10+8mbNunHKeNlxPY6n4ioyHLM3WpOoZvPWiRk8KczPppQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2791), false });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2817), true });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2829), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2829), false });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2914), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3006), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2885), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2999), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2918), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2982), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2975), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2894), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2976), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3019), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2897), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2921), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2985), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3003), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3020), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2986), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2995), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3004), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3012), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2987), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2996), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3005), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3036), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3041), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3046), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3051), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3056), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3031), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3042), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3027), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3033), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3053), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3058), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3034), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3044), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3049), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3093), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3099), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3029), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3040), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3045), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3055), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 12, 3, 13, 6, 20, 597, DateTimeKind.Local).AddTicks(3100) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2406), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2423), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "94105722-4b5f-4f5c-97b3-1498cd93e6d2", new DateTime(2023, 12, 3, 12, 57, 42, 171, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 12, 3, 12, 57, 42, 171, DateTimeKind.Local).AddTicks(9976), "AQAAAAIAAYagAAAAEEJzhY+zwub1O7HKf2s662KBwq2Lc83E/cEtQAfmy80bJ04vPp3IxfXuIcy1fWvW2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1bac9832-ebe4-4ee2-947b-a8c1572aef62", new DateTime(2023, 12, 3, 12, 57, 42, 19, DateTimeKind.Local).AddTicks(8092), new DateTime(2023, 12, 3, 12, 57, 42, 19, DateTimeKind.Local).AddTicks(8103), "AQAAAAIAAYagAAAAEOg3IYz+OdI166zIWIODRxyI3DmLgu0SD1qcW6xPsJ1vouFsu/D8PfccD/rq2lgiDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "51a4c184-47c3-4cca-aa3a-f9ba9e919c74", new DateTime(2023, 12, 3, 12, 57, 42, 97, DateTimeKind.Local).AddTicks(7848), new DateTime(2023, 12, 3, 12, 57, 42, 97, DateTimeKind.Local).AddTicks(7858), "AQAAAAIAAYagAAAAEDo3+ObPE6uPTsz8T31uJqOFXSbSE6lB0eDg06fnebMGGlFkH/oVqgcqHL2YD7O5Og==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9d4b2ab8-6741-41f2-883c-e7d0c83e9643", new DateTime(2023, 12, 3, 12, 57, 41, 949, DateTimeKind.Local).AddTicks(197), new DateTime(2023, 12, 3, 12, 57, 41, 949, DateTimeKind.Local).AddTicks(207), "AQAAAAIAAYagAAAAEHo9+rlGjCVVhZXCPjMj8VgytJJdUuunzgsIforStGAGJiUnoEnvdyf2Xfp6IqmP3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e7c72fe3-5eb5-4d46-ae3a-01554cb0f205", new DateTime(2023, 12, 3, 12, 57, 41, 880, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 12, 3, 12, 57, 41, 880, DateTimeKind.Local).AddTicks(2396), "AQAAAAIAAYagAAAAEHWVqGruPOVSgDxfHsm5sYbA1p0zAlvc4bUBaVT6xja4/7jz4tbbPGNUMkRVAw6rwg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2326), true });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2354), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2354), false });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "IsRequired" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2368), true });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2428), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2473), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2482), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2499), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2508), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2517), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2525), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2484), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2501), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2518), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2526), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2443), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2486), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2493), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2502), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2519), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2477), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2494), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2503), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2528), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2495), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2504), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2513), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2520), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2529), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2470), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2479), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2496), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2505), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2513), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2521), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2530), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2489), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2497), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2515), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2522), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2481), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2490), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2498), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2507), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2524), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2533), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2558), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2579), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2538), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2543), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2576), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2581), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 12, 3, 12, 57, 41, 875, DateTimeKind.Local).AddTicks(2582) });
        }
    }
}
