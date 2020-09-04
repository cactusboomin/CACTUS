using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class _update_entities3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "bc651960-4d52-4fdd-a307-1c2374d4111d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c22e9f43-0349-4360-ac5b-f438ba2ded08", "AQAAAAEAACcQAAAAEGhTGQPYE7/Xsk0udYsidYVfK+FytEi1Ut7GwtzNC6Vd5jmIG5Ro7fY3UCP4wnkIxA==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 1, 23, 52, 30, 671, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                columns: new[] { "FirstDateIsEnabled", "FirstDateName", "FirstNumberIsEnabled", "FirstNumberName", "FirstTextIsEnabled", "FirstTextName", "SecondCheckBoxIsEnabled", "SecondCheckBoxName", "SecondDateIsEnabled", "SecondDateName", "SecondNumberIsEnabled", "SecondNumberName", "SecondTextIsEnabled", "SecondTextName", "TimeAdded" },
                values: new object[] { false, null, false, null, false, null, true, "HA", true, "AWESOME", true, "IT'S", true, "BIPOLAR", new DateTime(2020, 9, 1, 23, 52, 30, 672, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                columns: new[] { "FirstCheckBoxName", "FirstDateName", "FirstNumberName", "FirstTextName", "TimeAdded" },
                values: new object[] { "SSSSS", "FFFFFFFFFFFF", "HABABAGAGAGA", "AAAAAAAA", new DateTime(2020, 9, 1, 23, 52, 30, 672, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "CollectionId", "FirstCheckBox", "FirstDate", "FirstNumber", "FirstText", "SecondDate", "SecondNumber", "SecondText", "TimeAdded" },
                values: new object[] { new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, new DateTime(2020, 9, 2, 2, 52, 30, 674, DateTimeKind.Local).AddTicks(3587), 10000000.0, "STRAIGHT UP", new DateTime(2020, 9, 1, 23, 52, 30, 674, DateTimeKind.Utc).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstCheckBox", "FirstDate", "FirstNumber", "TimeAdded" },
                values: new object[] { false, new DateTime(2020, 9, 2, 2, 52, 30, 674, DateTimeKind.Local).AddTicks(2380), 1000.0, new DateTime(2020, 9, 1, 23, 52, 30, 674, DateTimeKind.Utc).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 2, 2, 52, 30, 672, DateTimeKind.Local).AddTicks(9440), new DateTime(2020, 9, 1, 23, 52, 30, 672, DateTimeKind.Utc).AddTicks(7963) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "2086d762-a034-431e-aea1-232835837d4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81142d1c-ed0a-415a-8482-9609cbe01097", "AQAAAAEAACcQAAAAEO/4rKsPN1wGQVGeHByueR6rbt7LjdpyjX1KEwKEmTp0bM62lHyP8ZIUquKpaSsWqg==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 1, 22, 14, 58, 468, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                columns: new[] { "FirstDateIsEnabled", "FirstDateName", "FirstNumberIsEnabled", "FirstNumberName", "FirstTextIsEnabled", "FirstTextName", "SecondCheckBoxIsEnabled", "SecondCheckBoxName", "SecondDateIsEnabled", "SecondDateName", "SecondNumberIsEnabled", "SecondNumberName", "SecondTextIsEnabled", "SecondTextName", "TimeAdded" },
                values: new object[] { true, "AWESOME", true, "IT'S", true, "BIPOLAR", false, null, false, null, false, null, false, null, new DateTime(2020, 9, 1, 22, 14, 58, 469, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                columns: new[] { "FirstCheckBoxName", "FirstDateName", "FirstNumberName", "FirstTextName", "TimeAdded" },
                values: new object[] { "FFFFF", "AAAAAAAAAAAAAAAAAAAA", "HASGASG?", "ALFKASLF", new DateTime(2020, 9, 1, 22, 14, 58, 469, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "CollectionId", "FirstCheckBox", "FirstDate", "FirstNumber", "FirstText", "SecondDate", "SecondNumber", "SecondText", "TimeAdded" },
                values: new object[] { new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), false, new DateTime(2020, 9, 2, 1, 14, 58, 470, DateTimeKind.Local).AddTicks(7034), 3000.0, "STRAIGHT UP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, new DateTime(2020, 9, 1, 22, 14, 58, 470, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstCheckBox", "FirstDate", "FirstNumber", "TimeAdded" },
                values: new object[] { true, new DateTime(2020, 9, 2, 1, 14, 58, 470, DateTimeKind.Local).AddTicks(6963), 2000.0, new DateTime(2020, 9, 1, 22, 14, 58, 470, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 2, 1, 14, 58, 469, DateTimeKind.Local).AddTicks(3429), new DateTime(2020, 9, 1, 22, 14, 58, 469, DateTimeKind.Utc).AddTicks(2076) });
        }
    }
}
