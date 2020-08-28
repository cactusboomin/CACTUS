using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class _updating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "80a67246-0bf7-4b5d-b149-45b279988e07");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cd82ed0-6c3c-42ae-ba6b-af6f1c733b91", "AQAAAAEAACcQAAAAEEGew3+SSv5EBEcn3lpq2C67Ac0wgBP6s7tdUc+AbjewCfeMn49Qoc3dl4Gr91Tf+A==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                columns: new[] { "TimeAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2020, 8, 28, 15, 46, 6, 403, DateTimeKind.Utc).AddTicks(1334), "images/slimshady.jpg" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                columns: new[] { "TimeAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2020, 8, 28, 15, 46, 6, 403, DateTimeKind.Utc).AddTicks(9027), "images/kanyewest.jpg" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                columns: new[] { "TimeAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2020, 8, 28, 15, 46, 6, 403, DateTimeKind.Utc).AddTicks(8809), "images/travisscott.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 8, 28, 18, 46, 6, 405, DateTimeKind.Local).AddTicks(5190), new DateTime(2020, 8, 28, 15, 46, 6, 405, DateTimeKind.Utc).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 8, 28, 18, 46, 6, 405, DateTimeKind.Local).AddTicks(5040), new DateTime(2020, 8, 28, 15, 46, 6, 405, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 8, 28, 18, 46, 6, 404, DateTimeKind.Local).AddTicks(1674), new DateTime(2020, 8, 28, 15, 46, 6, 403, DateTimeKind.Utc).AddTicks(9673) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "399c8d9b-9c1b-4fdb-b85a-0166667d2ed0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36fc8efe-7993-479f-8cfb-3fa82a2f58d4", "AQAAAAEAACcQAAAAEA7fLz3GfwnNRH1+5bbc/hYJhwyjhhGf7GbVbZVHMQMzlP3WdNqjLAjBZGxNSiCZBQ==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                columns: new[] { "TimeAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(721), "~/images/slimshady.jpg" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                columns: new[] { "TimeAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(8462), "~/images/kanyewest.jpg" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                columns: new[] { "TimeAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(8222), "~/images/travisscott.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 8, 28, 17, 29, 21, 593, DateTimeKind.Local).AddTicks(4548), new DateTime(2020, 8, 28, 14, 29, 21, 593, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 8, 28, 17, 29, 21, 593, DateTimeKind.Local).AddTicks(4475), new DateTime(2020, 8, 28, 14, 29, 21, 593, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 8, 28, 17, 29, 21, 592, DateTimeKind.Local).AddTicks(1108), new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(9117) });
        }
    }
}
