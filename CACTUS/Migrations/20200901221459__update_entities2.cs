using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class _update_entities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "TimeAdded",
                value: new DateTime(2020, 9, 1, 22, 14, 58, 469, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 1, 22, 14, 58, 469, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 2, 1, 14, 58, 470, DateTimeKind.Local).AddTicks(7034), new DateTime(2020, 9, 1, 22, 14, 58, 470, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "CollectionId", "FirstDate", "TimeAdded" },
                values: new object[] { new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"), new DateTime(2020, 9, 2, 1, 14, 58, 470, DateTimeKind.Local).AddTicks(6963), new DateTime(2020, 9, 1, 22, 14, 58, 470, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 2, 1, 14, 58, 469, DateTimeKind.Local).AddTicks(3429), new DateTime(2020, 9, 1, 22, 14, 58, 469, DateTimeKind.Utc).AddTicks(2076) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "9e9e6223-bb3a-445c-9e29-5d25e3cf96a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "272cb6f8-593c-4305-b01b-1796e5628d2e", "AQAAAAEAACcQAAAAEB1b8CywfaT5CjsLF9CRiroZfYDS9NGKX/wbj9AE+byaH/CDHbNs9w64xtixzlXrlQ==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 1, 20, 26, 21, 866, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 1, 20, 26, 21, 867, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 1, 20, 26, 21, 867, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 1, 23, 26, 21, 869, DateTimeKind.Local).AddTicks(1630), new DateTime(2020, 9, 1, 20, 26, 21, 869, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "CollectionId", "FirstDate", "TimeAdded" },
                values: new object[] { new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), new DateTime(2020, 9, 1, 23, 26, 21, 869, DateTimeKind.Local).AddTicks(1555), new DateTime(2020, 9, 1, 20, 26, 21, 869, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 1, 23, 26, 21, 867, DateTimeKind.Local).AddTicks(4660), new DateTime(2020, 9, 1, 20, 26, 21, 867, DateTimeKind.Utc).AddTicks(2115) });
        }
    }
}
