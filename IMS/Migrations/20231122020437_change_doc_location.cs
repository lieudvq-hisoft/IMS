using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_doc_location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InspectionReportFilePath",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "InspectionReportFilePath",
                table: "RequestExpands");

            migrationBuilder.DropColumn(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestExpands");

            migrationBuilder.AddColumn<string>(
                name: "InspectionReportFilePath",
                table: "Appointments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptOfRecipientFilePath",
                table: "Appointments",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InspectionReportFilePath",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ReceiptOfRecipientFilePath",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "InspectionReportFilePath",
                table: "RequestUpgrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestUpgrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectionReportFilePath",
                table: "RequestExpands",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestExpands",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7647), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7659), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0943e718-2645-4bb8-bd48-c3749f6a7b25", new DateTime(2023, 11, 21, 21, 48, 5, 809, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 11, 21, 21, 48, 5, 809, DateTimeKind.Local).AddTicks(1145), "AQAAAAIAAYagAAAAEJSx30QCutvtEnPqQQQ4Fw47DxPuPzc7OUwNFYVsD+PC4lm9Ck6PIFRb5x5cSr7SuA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e976b57c-5d4b-4fe7-8041-75ed374954e4", new DateTime(2023, 11, 21, 21, 48, 5, 278, DateTimeKind.Local).AddTicks(1440), new DateTime(2023, 11, 21, 21, 48, 5, 278, DateTimeKind.Local).AddTicks(1454), "AQAAAAIAAYagAAAAECkaqEK0Pvw3LtQ8aYWXZd05Fy1DipQYxMmAFBKLJYeJaUl2+SV0dFFE6e4IzJfR9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e39cdb5f-fa6b-426d-82c8-93c23359093b", new DateTime(2023, 11, 21, 21, 48, 5, 410, DateTimeKind.Local).AddTicks(1263), new DateTime(2023, 11, 21, 21, 48, 5, 410, DateTimeKind.Local).AddTicks(1278), "AQAAAAIAAYagAAAAEIIj6LlpSmXIEV7dd6F1GevNDGTHadjGuvsrxShb63WLsA/i2JtXjdlUcGcUdX+wwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "dfd057da-12b7-4955-b95d-7092711261a4", new DateTime(2023, 11, 21, 21, 48, 5, 158, DateTimeKind.Local).AddTicks(8211), new DateTime(2023, 11, 21, 21, 48, 5, 158, DateTimeKind.Local).AddTicks(8226), "AQAAAAIAAYagAAAAEItf3YNHS7i22tBIHFOnXmn3B0PwBKatZXPXyLPFLAQwKgVmh+kcTBts1Xfj/YkUFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bfd87dc8-b09e-4778-ab5c-8a4061e010a6", new DateTime(2023, 11, 21, 21, 48, 5, 73, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 11, 21, 21, 48, 5, 73, DateTimeKind.Local).AddTicks(4774), "AQAAAAIAAYagAAAAEFtoV8iQQj8dj4YBoJvUgOkcmTkz289TeLFbuoqx7pVPwTb2tnxUJwZZNYOxvn70Sw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7417), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7513), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7523), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7531), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7564), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7578), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7588), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7679), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7695), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7705), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7715), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7725), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7684), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7696), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7707), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7716), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7734), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7752), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7761), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7686), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7698), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7708), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7763), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7687), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7699), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7719), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7736), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7764), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7688), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7711), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7720), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7691), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7702), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7712), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7721), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7738), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7692), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7703), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7713), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7693), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7704), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7759), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7784), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7796), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7801), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7807), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7813), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7773), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7785), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7791), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7797), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7802), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7808), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7814), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7786), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7792), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7798), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7804), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7809), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7815), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7776), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7782), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7787), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7793), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7799), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7805), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7816), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7777), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7783), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7789), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7794), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7806), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7811), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7817), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7818) });
        }
    }
}
