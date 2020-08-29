using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class _upupdating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "32e9d50f-5ccd-47fa-aa72-b9849a0ea26e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bc28cef-689b-4070-804c-597c6b3194a2", "AQAAAAEAACcQAAAAEKJru5OvOd3fZZOp+C7P/FhgjZ3J4ArAmyWsqo6+od3O0j64P9EGBJY8qE2t/CARbQ==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 8, 28, 22, 16, 50, 178, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 8, 28, 22, 16, 50, 178, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 8, 28, 22, 16, 50, 178, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 8, 29, 1, 16, 50, 180, DateTimeKind.Local).AddTicks(2684), new DateTime(2020, 8, 28, 22, 16, 50, 180, DateTimeKind.Utc).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 8, 29, 1, 16, 50, 180, DateTimeKind.Local).AddTicks(2618), new DateTime(2020, 8, 28, 22, 16, 50, 180, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 8, 29, 1, 16, 50, 179, DateTimeKind.Local).AddTicks(224), new DateTime(2020, 8, 28, 22, 16, 50, 178, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3169a29e-9fce-4f01-b9c0-05b3d3d5a20a"),
                column: "Name",
                value: "ROCK");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c21c3eb9-810b-43b5-98da-69f1edb6edd3"), "JAZZ" },
                    { new Guid("3e892139-3de4-490e-9ffe-e5580824a69c"), "PUNK" },
                    { new Guid("7ca274a2-b712-432d-9c6d-06fa36e4d444"), "METAL" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3e892139-3de4-490e-9ffe-e5580824a69c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7ca274a2-b712-432d-9c6d-06fa36e4d444"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c21c3eb9-810b-43b5-98da-69f1edb6edd3"));

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
                column: "TimeAdded",
                value: new DateTime(2020, 8, 28, 15, 46, 6, 403, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 8, 28, 15, 46, 6, 403, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 8, 28, 15, 46, 6, 403, DateTimeKind.Utc).AddTicks(8809));

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

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3169a29e-9fce-4f01-b9c0-05b3d3d5a20a"),
                column: "Name",
                value: "POP");
        }
    }
}
