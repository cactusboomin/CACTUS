using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class update_entities4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleImagePath",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "TitleImagePath",
                table: "Collections");

            migrationBuilder.AddColumn<byte[]>(
                name: "TitleImage",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TitleImage",
                table: "Collections",
                nullable: true);

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
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 21, 21, 53, 18, 604, DateTimeKind.Local).AddTicks(7095), new DateTime(2020, 9, 21, 18, 53, 18, 604, DateTimeKind.Utc).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 21, 21, 53, 18, 604, DateTimeKind.Local).AddTicks(5253), new DateTime(2020, 9, 21, 18, 53, 18, 604, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 21, 21, 53, 18, 603, DateTimeKind.Local).AddTicks(2542), new DateTime(2020, 9, 21, 18, 53, 18, 603, DateTimeKind.Utc).AddTicks(303) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleImage",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "TitleImage",
                table: "Collections");

            migrationBuilder.AddColumn<string>(
                name: "TitleImagePath",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleImagePath",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "TimeAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2020, 9, 18, 11, 35, 39, 245, DateTimeKind.Utc).AddTicks(4595), "images/slimshady.jpg" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                columns: new[] { "TimeAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2020, 9, 18, 11, 35, 39, 246, DateTimeKind.Utc).AddTicks(4911), "images/kanyewest.jpg" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                columns: new[] { "TimeAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2020, 9, 18, 11, 35, 39, 246, DateTimeKind.Utc).AddTicks(4715), "images/travisscott.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 18, 14, 35, 39, 249, DateTimeKind.Local).AddTicks(1449), new DateTime(2020, 9, 18, 11, 35, 39, 248, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 18, 14, 35, 39, 248, DateTimeKind.Local).AddTicks(8868), new DateTime(2020, 9, 18, 11, 35, 39, 248, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 18, 14, 35, 39, 247, DateTimeKind.Local).AddTicks(2878), new DateTime(2020, 9, 18, 11, 35, 39, 247, DateTimeKind.Utc).AddTicks(308) });
        }
    }
}
