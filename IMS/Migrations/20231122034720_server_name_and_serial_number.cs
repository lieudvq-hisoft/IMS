using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class server_name_and_serial_number : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "ServerAllocations",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RequestUpgrades",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Appointments",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "AppointedCustomer",
                table: "Appointments",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "89e94238-137f-438b-bc25-320ec6b9d6e1", new DateTime(2023, 11, 22, 10, 47, 20, 56, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 11, 22, 10, 47, 20, 56, DateTimeKind.Local).AddTicks(6285), "AQAAAAIAAYagAAAAEJ1vLoyKNj5wenVlRIAUXUW8BNSe1xJfxRO8L7RIQBSxExaNWvKevvNgowmpmU/8Xg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4e153400-5021-405a-a013-f6e640c8c8e2", new DateTime(2023, 11, 22, 10, 47, 19, 877, DateTimeKind.Local).AddTicks(1900), new DateTime(2023, 11, 22, 10, 47, 19, 877, DateTimeKind.Local).AddTicks(1911), "AQAAAAIAAYagAAAAEAq7U2scrOKZ/n7+aBdLS004AP025zPjia2B61FZYdCFL4hGb9eS/UnC6ez4LB6nVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7566971c-7da1-48da-9588-74dd3730b441", new DateTime(2023, 11, 22, 10, 47, 19, 946, DateTimeKind.Local).AddTicks(4912), new DateTime(2023, 11, 22, 10, 47, 19, 946, DateTimeKind.Local).AddTicks(4924), "AQAAAAIAAYagAAAAEKFo7LqLSMrrI3x4lyyzZ+7GbmUMkqi9C8X6E8s8LCFxNSv1PA7gVT4uNKfXpAEnEw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f992548e-bf48-49ed-bffb-fb85343f1e8e", new DateTime(2023, 11, 22, 10, 47, 19, 807, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 11, 22, 10, 47, 19, 807, DateTimeKind.Local).AddTicks(5169), "AQAAAAIAAYagAAAAEO9VJIZGAIyujwIcd/svf24jc0u302NCEPjxqdw2XKfAwHpAWElNteXD/lmXr4DiHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1f87b5d9-9d67-422f-a86a-60d1eb5a53b6", new DateTime(2023, 11, 22, 10, 47, 19, 737, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 11, 22, 10, 47, 19, 737, DateTimeKind.Local).AddTicks(2477), "AQAAAAIAAYagAAAAEENrthauNVNEmEpLd9rMZBZLmZKQ2HAtRtCuVQBr2IuQabXRjotUEyOrevz7amBaBw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9495), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9582), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9597), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9611), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9624), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9652), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9671), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9756), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9698), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9835), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9861), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9871), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9896), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9913), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9852), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9863), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9881), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9897), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9854), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9874), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9882), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9899), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9907), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9915), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9855), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9866), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9900), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9908), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9916), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9856), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9867), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9876), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9909), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9867), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9877), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9893), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9859), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9869), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9894), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9903), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9870), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9904), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9920), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9970), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9980), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9985), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9960), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9966), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9986), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9982), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9992), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9997), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9973), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9983), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9988), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9963), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9969), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9989), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9994), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9999), new DateTime(2023, 11, 22, 10, 47, 19, 731, DateTimeKind.Local).AddTicks(9999) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ServerAllocations");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "ServerAllocations");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RequestUpgrades",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Appointments",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppointedCustomer",
                table: "Appointments",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9834), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9852), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b4170689-50c4-4a87-8838-b711e5535f69", new DateTime(2023, 11, 22, 9, 4, 36, 772, DateTimeKind.Local).AddTicks(2051), new DateTime(2023, 11, 22, 9, 4, 36, 772, DateTimeKind.Local).AddTicks(2064), "AQAAAAIAAYagAAAAEKZZcxVA318WLohefibiAylAzYlc9xpBkFEUhxi2xACm4P6X9Sa5haLsDQIkPSnf/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "5cab66b1-ffd7-469d-9b94-a9ab9785b594", new DateTime(2023, 11, 22, 9, 4, 36, 629, DateTimeKind.Local).AddTicks(4873), new DateTime(2023, 11, 22, 9, 4, 36, 629, DateTimeKind.Local).AddTicks(4885), "AQAAAAIAAYagAAAAEAVGVDt/AnG5YaV+rpHH6wOsCkJ9xyqWqS1Q5tVQJ2IcgM2iku7eLmlqpdLSB086MQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9dfa6347-ac6c-49d9-a252-25da35c33fe9", new DateTime(2023, 11, 22, 9, 4, 36, 699, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 11, 22, 9, 4, 36, 699, DateTimeKind.Local).AddTicks(2882), "AQAAAAIAAYagAAAAEC93pmnrqSFFBlH+MKdlENwfqZbrRar8/DY3U1ayzbm+iYefOOMPV9H0+vFfffMbtw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f857a75f-8d2d-4457-bb41-7aed80d2fc68", new DateTime(2023, 11, 22, 9, 4, 36, 561, DateTimeKind.Local).AddTicks(4386), new DateTime(2023, 11, 22, 9, 4, 36, 561, DateTimeKind.Local).AddTicks(4397), "AQAAAAIAAYagAAAAEGTQYM2NkwzRKV0LIqpfH8llMDRAqWW7bBzYRomYzeMPbf/la0sfvG6MraKk1dz08A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "13b31688-1bda-444e-844d-e912056325d1", new DateTime(2023, 11, 22, 9, 4, 36, 493, DateTimeKind.Local).AddTicks(6931), new DateTime(2023, 11, 22, 9, 4, 36, 493, DateTimeKind.Local).AddTicks(6940), "AQAAAAIAAYagAAAAEH847v8Z6rbW83ra+eXPF7dzPK6PKoa8hgT3xUjgpZyeXxaaJ268RJOsj5waCBwf6A==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9533), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9629), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9643), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9655), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9752), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9792), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9859), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9894), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9903), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9920), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9928), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9936), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9896), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9904), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9913), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9921), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9929), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9937), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9877), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9897), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9930), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9970), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9898), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9915), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9899), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9907), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9916), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9924), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9932), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9973), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9881), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9900), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9908), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9925), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9933), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9882), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9909), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9934), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9893), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9927), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9935), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9989), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9994), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(10), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9980), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9985), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(1), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(11), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(16), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9986), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(2), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(6), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(11), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(17), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9982), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9992), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9997), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(2), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(7), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(12), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(18), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9983), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9988), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 11, 22, 9, 4, 36, 488, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(3), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(8), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(14), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(19), new DateTime(2023, 11, 22, 9, 4, 36, 489, DateTimeKind.Local).AddTicks(19) });
        }
    }
}
