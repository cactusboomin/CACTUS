using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class _update_users_roles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "63d2ddb5-aabe-4a07-9c8c-d2bb76fcd668", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "4d041b94-1bc3-4aad-9409-5c432ae872bd", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9067b485-a103-4e29-a01b-13d878d1e176", "AQAAAAEAACcQAAAAEECt36byHQ/aqtm+YqiYcleMmhDmwO9lVxrmr2X+gMUEMZ0PonnuhZJMhBfXQpZ09w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc9ef7a9-3eb5-4ff2-8cfc-edcb6123bd7a", "AQAAAAEAACcQAAAAEH3f9c0m9cOZ1lrEJrOHd8QMJPkZF4yyFr2Eh9ta/e+qfE19J7MXUbEnOEOJO7b+dg==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 12, 23, 19, 16, 648, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 12, 23, 19, 16, 649, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 12, 23, 19, 16, 649, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 19, 16, 717, DateTimeKind.Local).AddTicks(4368), new DateTime(2020, 9, 12, 23, 19, 16, 717, DateTimeKind.Utc).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 19, 16, 717, DateTimeKind.Local).AddTicks(3098), new DateTime(2020, 9, 12, 23, 19, 16, 717, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 19, 16, 650, DateTimeKind.Local).AddTicks(3686), new DateTime(2020, 9, 12, 23, 19, 16, 650, DateTimeKind.Utc).AddTicks(1209) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "6842afba-4ffc-488d-a42a-0fa11dfe5874", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "7bda32e5-6030-4765-bb64-fd8c8b9c97b3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ef1ec56-703c-4245-b365-b544e554e068", "AQAAAAEAACcQAAAAEI9QdRsX5ixNLCbbe1ywQTceoOgT5TOKiXqIQh/UsD3EE9G2hi7Lf/yjjKBOeCXSRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f98ee749-ed54-4ec8-be1e-57a87435b3fa", "AQAAAAEAACcQAAAAEJlkb+3tcjd0i6ZdZiq7psvIAaJ496jh+SygknHFAJV/9ci/qPkmG+WGrkhHMwRP0A==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 11, 23, 7, 58, 89, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 11, 23, 7, 58, 89, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 11, 23, 7, 58, 89, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 12, 2, 7, 58, 91, DateTimeKind.Local).AddTicks(9478), new DateTime(2020, 9, 11, 23, 7, 58, 91, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 12, 2, 7, 58, 91, DateTimeKind.Local).AddTicks(7835), new DateTime(2020, 9, 11, 23, 7, 58, 91, DateTimeKind.Utc).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 12, 2, 7, 58, 90, DateTimeKind.Local).AddTicks(5230), new DateTime(2020, 9, 11, 23, 7, 58, 90, DateTimeKind.Utc).AddTicks(3150) });
        }
    }
}
