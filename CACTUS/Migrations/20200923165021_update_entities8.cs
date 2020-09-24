using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class update_entities8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "d6c83af5-76b1-4fda-81df-954ffc809075");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "110d59a3-b097-4d77-ab14-ef28d04e80a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09ff10b8-a44a-4c85-b3a2-eed162880de2", "AQAAAAEAACcQAAAAEJRwgAl+B6d9dPokrkCYfqREp6t++IZSyzRJKkAsvUl50RH/6meWZOxZ96VxI97HSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b33526ab-a404-435a-8971-458d7b6c4611", "AQAAAAEAACcQAAAAECWRyfEjuZ+S/KURgzdN/Tb/veJHb+79g6cdBYVi+UjX1YqnKgkRUexhQiYuLXoblA==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 50, 20, 2, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 50, 20, 3, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 50, 20, 3, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 50, 20, 6, DateTimeKind.Local).AddTicks(6738), new DateTime(2020, 9, 23, 16, 50, 20, 6, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 50, 20, 6, DateTimeKind.Local).AddTicks(4627), new DateTime(2020, 9, 23, 16, 50, 20, 6, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 50, 20, 4, DateTimeKind.Local).AddTicks(8150), new DateTime(2020, 9, 23, 16, 50, 20, 4, DateTimeKind.Utc).AddTicks(5745) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "0ab9ce0a-55b7-497a-a456-ce320e184484");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "4fb4ee68-4599-4b12-8b9e-87de1c85171d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d6cbea0-7ba5-44d5-be9a-491a2f6b7b53", "AQAAAAEAACcQAAAAEAIpR1hiw+LajWSPilEGzTNilJHBC0HpV2uP73BqdZkdaBsIjMVsnqTgpAjHnCj7gg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c772f8f-f78c-43e0-92f2-e0ff027622f2", "AQAAAAEAACcQAAAAECck0Xul7RN8hOCBxHSzfLzvjz3ilNw0ZIV0ZgMM35gPKcq380uDDJh/CT3Ngs+Iiw==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 18, 29, 877, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 18, 29, 879, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 18, 29, 879, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 18, 29, 884, DateTimeKind.Local).AddTicks(3517), new DateTime(2020, 9, 23, 16, 18, 29, 883, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 18, 29, 883, DateTimeKind.Local).AddTicks(9435), new DateTime(2020, 9, 23, 16, 18, 29, 883, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 18, 29, 880, DateTimeKind.Local).AddTicks(4582), new DateTime(2020, 9, 23, 16, 18, 29, 880, DateTimeKind.Utc).AddTicks(1471) });
        }
    }
}
