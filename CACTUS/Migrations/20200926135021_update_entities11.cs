using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class update_entities11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    Item = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
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
                value: "2dd57990-308c-4021-8829-0ee52bae1c5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "64cd417d-ddab-462c-a0d1-2fac0d3c76d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0674014f-623f-40f8-8990-e328ab42cbcd", "AQAAAAEAACcQAAAAEMkwFKlD6P9oYva489VJNunjnxtFa9bANXGe2+4nCxYpRstVv9ogFKFtycSV5B6TkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "952bcb84-93d9-4035-8aac-1cacebf951c8", "AQAAAAEAACcQAAAAEDG8ivImAd4WtcpcZ6rnOcNA5ARb+Pmkqskvl53vCrYeLkBIfPZSRwN5cJT8Q34RIw==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 26, 13, 50, 20, 269, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 26, 13, 50, 20, 270, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 26, 13, 50, 20, 270, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 26, 16, 50, 20, 272, DateTimeKind.Local).AddTicks(8516), new DateTime(2020, 9, 26, 13, 50, 20, 272, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 26, 16, 50, 20, 272, DateTimeKind.Local).AddTicks(6727), new DateTime(2020, 9, 26, 13, 50, 20, 272, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 26, 16, 50, 20, 270, DateTimeKind.Local).AddTicks(9755), new DateTime(2020, 9, 26, 13, 50, 20, 270, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "321aebbe-3946-477d-afe3-e7f523e7bd6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "2cff096c-e9a2-4116-9d68-3df2709f2560");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a96a5bb-2691-4d12-9a5a-9eaaf31918cf", "AQAAAAEAACcQAAAAELlvBRm4kfHn3qPF2T+v/hN0XF5Oh4JpMYwxMWRclDdWdj4+h5nXAxkquZdr/Drx8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a44508c-cd99-4c7b-86e8-9d5a83c0e918", "AQAAAAEAACcQAAAAEInlrq9qcfI5Y/XVDQklSrJmHdJiQ0pg7fnycjIA1kC34JTsJWNHzmoNjOo3rmmggQ==" });

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 20, 37, 47, 39, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 20, 37, 47, 40, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                column: "TimeAdded",
                value: new DateTime(2020, 9, 23, 20, 37, 47, 40, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                columns: new[] { "SecondDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 23, 37, 47, 43, DateTimeKind.Local).AddTicks(2840), new DateTime(2020, 9, 23, 20, 37, 47, 43, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 23, 37, 47, 43, DateTimeKind.Local).AddTicks(1414), new DateTime(2020, 9, 23, 20, 37, 47, 43, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                columns: new[] { "FirstDate", "TimeAdded" },
                values: new object[] { new DateTime(2020, 9, 23, 23, 37, 47, 41, DateTimeKind.Local).AddTicks(2604), new DateTime(2020, 9, 23, 20, 37, 47, 41, DateTimeKind.Utc).AddTicks(826) });
        }
    }
}
