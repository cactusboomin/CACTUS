using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class _update_entities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Items",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Collections",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
                columns: new[] { "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 3, 42, 201, DateTimeKind.Utc).AddTicks(2259), "7DF74B2D-5189-4622-BD09-FE6337C18C3D" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                columns: new[] { "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 3, 42, 202, DateTimeKind.Utc).AddTicks(405), "7DF74B2D-5189-4622-BD09-FE6337C18C3D" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                columns: new[] { "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 3, 42, 202, DateTimeKind.Utc).AddTicks(163), "7DF74B2D-5189-4622-BD09-FE6337C18C3D" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 13, 23, 3, 42, 204, DateTimeKind.Local).AddTicks(1383), new DateTime(2020, 9, 13, 20, 3, 42, 203, DateTimeKind.Utc).AddTicks(9740), "7DF74B2D-5189-4622-BD09-FE6337C18C3D" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 13, 23, 3, 42, 203, DateTimeKind.Local).AddTicks(9719), new DateTime(2020, 9, 13, 20, 3, 42, 203, DateTimeKind.Utc).AddTicks(9632), "7DF74B2D-5189-4622-BD09-FE6337C18C3D" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 13, 23, 3, 42, 202, DateTimeKind.Local).AddTicks(7236), new DateTime(2020, 9, 13, 20, 3, 42, 202, DateTimeKind.Utc).AddTicks(5202), "7DF74B2D-5189-4622-BD09-FE6337C18C3D" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Items",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Collections",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "63d2ddb5-aabe-4a07-9c8c-d2bb76fcd668");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "4d041b94-1bc3-4aad-9409-5c432ae872bd");

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
                columns: new[] { "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 19, 16, 648, DateTimeKind.Utc).AddTicks(5001), new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                columns: new[] { "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 19, 16, 649, DateTimeKind.Utc).AddTicks(5718), new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                columns: new[] { "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 12, 23, 19, 16, 649, DateTimeKind.Utc).AddTicks(5346), new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 19, 16, 717, DateTimeKind.Local).AddTicks(4368), new DateTime(2020, 9, 12, 23, 19, 16, 717, DateTimeKind.Utc).AddTicks(3128), new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 19, 16, 717, DateTimeKind.Local).AddTicks(3098), new DateTime(2020, 9, 12, 23, 19, 16, 717, DateTimeKind.Utc).AddTicks(2983), new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded", "UserId" },
                values: new object[] { new DateTime(2020, 9, 13, 2, 19, 16, 650, DateTimeKind.Local).AddTicks(3686), new DateTime(2020, 9, 12, 23, 19, 16, 650, DateTimeKind.Utc).AddTicks(1209), new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") });
        }
    }
}
