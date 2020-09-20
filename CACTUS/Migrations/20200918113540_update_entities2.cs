using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class update_entities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ThirdNumber",
                table: "Items",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThirdDate",
                table: "Items",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "ThirdCheckBox",
                table: "Items",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<double>(
                name: "SecondNumber",
                table: "Items",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SecondDate",
                table: "Items",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SecondCheckBox",
                table: "Items",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<double>(
                name: "FirstNumber",
                table: "Items",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstDate",
                table: "Items",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "FirstCheckBox",
                table: "Items",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Collections",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "521ecd58-fc02-4a6e-94e6-97afa174a0e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "df7fa8fa-ae68-4f50-af9b-b90bf9a4024a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "968a4bd9-31e8-461d-96a9-342f0b3356fd", "AQAAAAEAACcQAAAAEL3J18+FXoSX6AdUVmr/u3YDp+HF5WjgyfqJnkGH8USN7Od4uvDQzs7W1y7rlQFTUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf1156a1-d0b6-46e7-a12b-21220b872d71", "AQAAAAEAACcQAAAAELNFwIoAMDF6a5FNnukr8HX0ypn2lrG6NsQNpirp6OYEOR4+RWxKXTShE5ElbeaFmQ==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 18, 11, 35, 39, 245, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 18, 11, 35, 39, 246, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 18, 11, 35, 39, 246, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "FirstDate", "FirstNumber", "SecondDate", "ThirdCheckBox", "ThirdDate", "ThirdNumber", "TimeAdded" },
                values: new object[] { null, null, new DateTime(2020, 9, 18, 14, 35, 39, 249, DateTimeKind.Local).AddTicks(1449), null, null, null, new DateTime(2020, 9, 18, 11, 35, 39, 248, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "SecondCheckBox", "SecondDate", "SecondNumber", "ThirdCheckBox", "ThirdDate", "ThirdNumber", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 18, 14, 35, 39, 248, DateTimeKind.Local).AddTicks(8868), null, null, null, null, null, null, new DateTime(2020, 9, 18, 11, 35, 39, 248, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "SecondCheckBox", "SecondDate", "SecondNumber", "ThirdCheckBox", "ThirdDate", "ThirdNumber", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 18, 14, 35, 39, 247, DateTimeKind.Local).AddTicks(2878), null, null, null, null, null, null, new DateTime(2020, 9, 18, 11, 35, 39, 247, DateTimeKind.Utc).AddTicks(308) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.AlterColumn<double>(
                name: "ThirdNumber",
                table: "Items",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThirdDate",
                table: "Items",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ThirdCheckBox",
                table: "Items",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "SecondNumber",
                table: "Items",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SecondDate",
                table: "Items",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SecondCheckBox",
                table: "Items",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "FirstNumber",
                table: "Items",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstDate",
                table: "Items",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FirstCheckBox",
                table: "Items",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "e674d933-acc2-48f6-86d9-babfffa7bb79");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "704142bc-159e-4d23-90d8-1c102caf9cd3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "227058d7-0943-4d6a-98ac-85f0ab9f493c", "AQAAAAEAACcQAAAAEGk5DcwGcuZsOtWaEQ/At452xgU4qnD0LwPqo/k/x2JWUErvU9veUifTQmlNJ5mM2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a4c885e-ca67-4f67-8037-7a913b3a981e", "AQAAAAEAACcQAAAAEBKbIstDSOgTZ+aL/+S+3wmjH5oQosPA6fkVzl5lRjzDFVMv42YxqSd7sxKfojESbg==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 13, 20, 3, 42, 201, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 13, 20, 3, 42, 202, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 13, 20, 3, 42, 202, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "FirstDate", "FirstNumber", "SecondDate", "ThirdCheckBox", "ThirdDate", "ThirdNumber", "TimeAdded" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(2020, 9, 13, 23, 3, 42, 204, DateTimeKind.Local).AddTicks(1383), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(2020, 9, 13, 20, 3, 42, 203, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "SecondCheckBox", "SecondDate", "SecondNumber", "ThirdCheckBox", "ThirdDate", "ThirdNumber", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 13, 23, 3, 42, 203, DateTimeKind.Local).AddTicks(9719), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(2020, 9, 13, 20, 3, 42, 203, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "SecondCheckBox", "SecondDate", "SecondNumber", "ThirdCheckBox", "ThirdDate", "ThirdNumber", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 13, 23, 3, 42, 202, DateTimeKind.Local).AddTicks(7236), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, new DateTime(2020, 9, 13, 20, 3, 42, 202, DateTimeKind.Utc).AddTicks(5202) });
        }
    }
}
