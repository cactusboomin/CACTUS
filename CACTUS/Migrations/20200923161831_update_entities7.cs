using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class update_entities7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "a171f823-2b37-45d8-a37b-fe63b820fde2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "12c8bf46-523c-43a8-8a2d-4edadd8f4ce4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58559ab9-8b14-4d5c-88ef-88d18201d82c", "AQAAAAEAACcQAAAAEL6ZDW2230hL62NKuodbGzKtj0EBrp3P9d+sbiXUoJyIPePAtrRz4MJ2fj2IhsipIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3ecb184-c708-4118-8ba7-6b5fad9bf097", "AQAAAAEAACcQAAAAECe51LswBXCMTfHBQkNd+mJzydTSsfe+Xu5fuecOn0nmyW5Lmj0uHGj62gNHPmFzVA==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 13, 53, 797, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 13, 53, 798, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 16, 13, 53, 798, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 13, 53, 801, DateTimeKind.Local).AddTicks(4667), new DateTime(2020, 9, 23, 16, 13, 53, 801, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 13, 53, 801, DateTimeKind.Local).AddTicks(2471), new DateTime(2020, 9, 23, 16, 13, 53, 801, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 19, 13, 53, 799, DateTimeKind.Local).AddTicks(5473), new DateTime(2020, 9, 23, 16, 13, 53, 799, DateTimeKind.Utc).AddTicks(2689) });
        }
    }
}
