using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class update_entities5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ThirdCheckBox",
                table: "Items",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SecondCheckBox",
                table: "Items",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FirstCheckBox",
                table: "Items",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "6030e19a-b6fc-4bed-a450-104d47a7afa6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "0edca9b1-7ffd-4099-949a-d2d35eb6e461");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aef36848-8671-4070-8d4b-4cf4223f178e", "AQAAAAEAACcQAAAAECk3eN1L8Heh1BHIpZgG07VV5FKFO7icKF+MfcypeNiwTy5eBsb5r+pRwFKSyM8XAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbefdc1b-e53e-43a9-b381-259f05f01d74", "AQAAAAEAACcQAAAAEOq14lDZ03E2PJT9U4AKtLEDwVciBnQVrPqUmUP6i8wzpHM2g/w/pTpTaAYS7321iQ==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 11, 58, 874, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 11, 58, 875, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 11, 58, 875, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "ThirdCheckBox", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 11, 58, 878, DateTimeKind.Local).AddTicks(2281), false, new DateTime(2020, 9, 23, 16, 11, 58, 878, DateTimeKind.Utc).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "SecondCheckBox", "ThirdCheckBox", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 11, 58, 878, DateTimeKind.Local).AddTicks(117), false, false, new DateTime(2020, 9, 23, 16, 11, 58, 877, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "SecondCheckBox", "ThirdCheckBox", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 11, 58, 876, DateTimeKind.Local).AddTicks(3987), false, false, new DateTime(2020, 9, 23, 16, 11, 58, 876, DateTimeKind.Utc).AddTicks(1068) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ThirdCheckBox",
                table: "Items",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "SecondCheckBox",
                table: "Items",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "FirstCheckBox",
                table: "Items",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "33226f40-3805-4297-96ed-77dc6a4f82f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "a3202ce1-d34c-4ae9-9d60-87c577cf79ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfb4dbc0-92f4-44ed-a913-93bc31e1adb7", "AQAAAAEAACcQAAAAEN/suX4onyhSSJQaP40KmjF0oY0t/QEY57Az8yoS8NRUS+CTx/DUPEc3zISQlbTBLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31f704e6-3d4c-4688-8973-393a97808c06", "AQAAAAEAACcQAAAAENucXDC03g31aw5Kxq5GkbYl0m3hnB5tFn5Y1NPE9DXEnuXBzvMRQN5uXOEz+nzgvg==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 21, 18, 53, 18, 601, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 21, 18, 53, 18, 602, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 21, 18, 53, 18, 602, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "ThirdCheckBox", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 21, 21, 53, 18, 604, DateTimeKind.Local).AddTicks(7095), null, new DateTime(2020, 9, 21, 18, 53, 18, 604, DateTimeKind.Utc).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "SecondCheckBox", "ThirdCheckBox", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 21, 21, 53, 18, 604, DateTimeKind.Local).AddTicks(5253), null, null, new DateTime(2020, 9, 21, 18, 53, 18, 604, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "SecondCheckBox", "ThirdCheckBox", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 21, 21, 53, 18, 603, DateTimeKind.Local).AddTicks(2542), null, null, new DateTime(2020, 9, 21, 18, 53, 18, 603, DateTimeKind.Utc).AddTicks(303) });
        }
    }
}
