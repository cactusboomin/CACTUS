using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class update_entities9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.ItemId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Likes_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "58f4b057-2257-4289-862c-30091579cd78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "e00e444e-d52d-46c1-b883-57c534f4f9ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c318f763-21d2-4364-8684-baabc1a9c388", "AQAAAAEAACcQAAAAEHMo/Hep8iRMMn+qdP8LK8mtUqCFymI+HyLkwya2Wz095wyWG1A/v8+mRdZULnufXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3523fb81-82df-4fce-855b-b570c60a436d", "AQAAAAEAACcQAAAAEF0KkE/f2rDyMvbI5oGtDdyJYL2uq0zpEks0wwfmbYRbaDEMTdAHjTQ+cC3wiWLhNw==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 20, 26, 56, 139, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 20, 26, 56, 140, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 20, 26, 56, 140, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 23, 26, 56, 142, DateTimeKind.Local).AddTicks(2682), new DateTime(2020, 9, 23, 20, 26, 56, 142, DateTimeKind.Utc).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 23, 26, 56, 142, DateTimeKind.Local).AddTicks(1215), new DateTime(2020, 9, 23, 20, 26, 56, 142, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 23, 26, 56, 140, DateTimeKind.Local).AddTicks(7026), new DateTime(2020, 9, 23, 20, 26, 56, 140, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
    }
}
