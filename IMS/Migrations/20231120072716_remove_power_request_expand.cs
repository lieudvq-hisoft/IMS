using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class remove_power_request_expand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Power",
                table: "RequestExpands");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7248), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "10302adc-9bc0-4cdc-9e32-3d3394f37c17", new DateTime(2023, 11, 20, 14, 27, 15, 177, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 11, 20, 14, 27, 15, 177, DateTimeKind.Local).AddTicks(9902), "AQAAAAIAAYagAAAAEIIS957XhTCyysn/QroYZTqHSXaRRRXCUoiHe4Xn/RQZIrqfYVcb5YdXsOVPE28vRQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2ba5fcb9-26f4-4824-a413-ea46cf482baf", new DateTime(2023, 11, 20, 14, 27, 15, 15, DateTimeKind.Local).AddTicks(7763), new DateTime(2023, 11, 20, 14, 27, 15, 15, DateTimeKind.Local).AddTicks(7776), "AQAAAAIAAYagAAAAEG/1EmJl4g4KMr2DnbulatwzRXCdlbQQOuWdFexmm24pFlBH+OMYfFgKCV667gKxgA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e604dc00-58d8-4f97-afa1-8d647af2b95e", new DateTime(2023, 11, 20, 14, 27, 15, 92, DateTimeKind.Local).AddTicks(9366), new DateTime(2023, 11, 20, 14, 27, 15, 92, DateTimeKind.Local).AddTicks(9377), "AQAAAAIAAYagAAAAEOq0MCcfBFb9BtnQXpNTn50affkD4L8BnF4uiL8IB4U5egrXEUkp6bW2Qtl9vG7usg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "21a86227-1882-4708-9d3e-9e59576787f1", new DateTime(2023, 11, 20, 14, 27, 14, 939, DateTimeKind.Local).AddTicks(1437), new DateTime(2023, 11, 20, 14, 27, 14, 939, DateTimeKind.Local).AddTicks(1449), "AQAAAAIAAYagAAAAEBRgQMh9BtcaXit0gfE/Qmfy8090yXlaIfw6XcU5f4wHRSp/SUzfPBpulc7ECVNELw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "396d47e1-549a-4167-828a-abb88209ff0b", new DateTime(2023, 11, 20, 14, 27, 14, 870, DateTimeKind.Local).AddTicks(5463), new DateTime(2023, 11, 20, 14, 27, 14, 870, DateTimeKind.Local).AddTicks(5469), "AQAAAAIAAYagAAAAEL2m/ag5m4XA8mlp9/ddRArPPVAQAdUJQ01ERyZ7F5tbr7+m3t0p+kBn9udMX6+pVg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(6956), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7051), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7067), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7079), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7091), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7112), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7131), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7144), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7169), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7182), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7157), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7254), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7292), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7362), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7371), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7379), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7387), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7283), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7293), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7347), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7364), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7372), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7285), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7294), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7348), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7356), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7365), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7373), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7381), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7286), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7295), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7374), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7382), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7390), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7287), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7296), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7350), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7358), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7367), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7375), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7391), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7359), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7368), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7384), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7290), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7298), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7352), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7377), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7393), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7291), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7299), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7353), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7361), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7395), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7402), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7407), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7417), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7422), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7469), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7398), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7408), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7413), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7418), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7470), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7399), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7404), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7409), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7414), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7424), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7400), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7425), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7467), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7472), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7401), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7406), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7411), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7421), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7468), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7473), new DateTime(2023, 11, 20, 14, 27, 14, 865, DateTimeKind.Local).AddTicks(7473) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "RequestExpands",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2427), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2442), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c5623078-64e1-4c69-891a-d77c1f84400c", new DateTime(2023, 11, 20, 12, 21, 32, 732, DateTimeKind.Local).AddTicks(7178), new DateTime(2023, 11, 20, 12, 21, 32, 732, DateTimeKind.Local).AddTicks(7193), "AQAAAAIAAYagAAAAECb/G2yW50zs/bpgVVXUpaWwQXVjQhG+5vvq7pc3a1smFXEhyK2zlcDUrQfMR2Ygyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "795f8cb8-c483-4d3f-a228-94d8134285f6", new DateTime(2023, 11, 20, 12, 21, 32, 430, DateTimeKind.Local).AddTicks(6607), new DateTime(2023, 11, 20, 12, 21, 32, 430, DateTimeKind.Local).AddTicks(6619), "AQAAAAIAAYagAAAAEJG2BkfYnt/P67L3SV2jJARxfaKC9m2rlO8q78DFoNG4Rne1QpmGENraYFnZGYq/ew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "421a97f8-2ab9-4169-a395-01aa0deb4a20", new DateTime(2023, 11, 20, 12, 21, 32, 564, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 11, 20, 12, 21, 32, 564, DateTimeKind.Local).AddTicks(9185), "AQAAAAIAAYagAAAAEBRw0b0Y9C8OlWcBYbbgXxZq6RbRoO4X4Or+ytZNkhCLS6r8H7sAfgs36seczkBvEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3c0c362e-90a2-449e-aa12-60297422f9b6", new DateTime(2023, 11, 20, 12, 21, 32, 327, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 11, 20, 12, 21, 32, 327, DateTimeKind.Local).AddTicks(6427), "AQAAAAIAAYagAAAAEIxhvFzNNNbyFKUhO47jHXaUcVNf0ypteGxs7R8/+l0z6u9e7vM03SVVGgaVj7hf1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "31b265e4-a208-4d86-a588-0db5d4afd38e", new DateTime(2023, 11, 20, 12, 21, 32, 221, DateTimeKind.Local).AddTicks(7577), new DateTime(2023, 11, 20, 12, 21, 32, 221, DateTimeKind.Local).AddTicks(7598), "AQAAAAIAAYagAAAAEEaaDHNqzW9p03C2yLBq25p2W2dQ0MTMWtXJ9v/kMxMikJqM4dU8HrFiOFni+vXafQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2244), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2333), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2381), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2396), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2358), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2669), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2709), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2644), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2656), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2685), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2699), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2645), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2658), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2672), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2543), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2647), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2689), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2702), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2714), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2661), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2716), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2650), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2662), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2677), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2692), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2717), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2679), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2721), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2748), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2765), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2773), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2766), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2751), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2759), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2737), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2747), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 11, 20, 12, 21, 32, 215, DateTimeKind.Local).AddTicks(2841) });
        }
    }
}
