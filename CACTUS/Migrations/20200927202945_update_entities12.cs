using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class update_entities12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7DF74B2D-5189-4622-BD09-FE6337C18C3D", "1E2EFB41-DAA4-4643-9E94-418D05609F57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda", "02d962c8-3531-41e9-bf0f-bdf29fb0b745" });

            migrationBuilder.DeleteData(
                table: "ItemTag",
                keyColumns: new[] { "ItemId", "TagId" },
                keyValues: new object[] { new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"), new Guid("2bf21f1c-ed7a-4943-a844-7eb7ddc66447") });

            migrationBuilder.DeleteData(
                table: "ItemTag",
                keyColumns: new[] { "ItemId", "TagId" },
                keyValues: new object[] { new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"), new Guid("6d067807-2076-4c1f-9e2b-1d766e8bef2c") });

            migrationBuilder.DeleteData(
                table: "ItemTag",
                keyColumns: new[] { "ItemId", "TagId" },
                keyValues: new object[] { new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"), new Guid("6a179fe5-db82-4cf2-b529-00359bf5b99d") });

            migrationBuilder.DeleteData(
                table: "ItemTag",
                keyColumns: new[] { "ItemId", "TagId" },
                keyValues: new object[] { new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"), new Guid("ac7e2eb6-ffb3-4f9e-bbda-1574c07f47bc") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2bf21f1c-ed7a-4943-a844-7eb7ddc66447"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6a179fe5-db82-4cf2-b529-00359bf5b99d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6d067807-2076-4c1f-9e2b-1d766e8bef2c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ac7e2eb6-ffb3-4f9e-bbda-1574c07f47bc"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                column: "ConcurrencyStamp",
                value: "c3aafa66-22b0-45fc-9e12-fc491349b8f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "68c64fbd-017d-41ea-bada-2a1f98e24824");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7DF74B2D-5189-4622-BD09-FE6337C18C3D", 0, "0674014f-623f-40f8-8990-e328ab42cbcd", "123@mail.ru", true, false, null, "123@MAIL.RU", "ADMIN", "AQAAAAEAACcQAAAAEMkwFKlD6P9oYva489VJNunjnxtFa9bANXGe2+4nCxYpRstVv9ogFKFtycSV5B6TkQ==", null, false, "", false, "admin" },
                    { "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda", 0, "952bcb84-93d9-4035-8aac-1cacebf951c8", "oc@yandex.by", true, false, null, "OC@YANDEX.BY", "USER", "AQAAAAEAACcQAAAAEDG8ivImAd4WtcpcZ6rnOcNA5ARb+Pmkqskvl53vCrYeLkBIfPZSRwN5cJT8Q34RIw==", null, false, "", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "FirstCheckBoxIsEnabled", "FirstCheckBoxName", "FirstDateIsEnabled", "FirstDateName", "FirstNumberIsEnabled", "FirstNumberName", "FirstTextIsEnabled", "FirstTextName", "SecondCheckBoxIsEnabled", "SecondCheckBoxName", "SecondDateIsEnabled", "SecondDateName", "SecondNumberIsEnabled", "SecondNumberName", "SecondTextIsEnabled", "SecondTextName", "Theme", "ThirdCheckBoxIsEnabled", "ThirdCheckBoxName", "ThirdDateIsEnabled", "ThirdDateName", "ThirdNumberIsEnabled", "ThirdNumberName", "ThirdTextIsEnabled", "ThirdTextName", "TimeAdded", "Title", "TitleImage", "UserId" },
                values: new object[,]
                {
                    { new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), "LALALA", true, "LOL", true, "SLIM SHADY", true, "HUH?", true, "MY NAME IS", false, null, false, null, false, null, false, null, "OLD SCHOOL", false, null, false, null, false, null, false, null, new DateTime(2020, 9, 26, 13, 50, 20, 269, DateTimeKind.Utc).AddTicks(5033), "SLIM SHADY", null, "7DF74B2D-5189-4622-BD09-FE6337C18C3D" },
                    { new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"), "ITS LIT", true, "SSSSS", true, "FFFFFFFFFFFF", true, "HABABAGAGAGA", true, "AAAAAAAA", false, null, false, null, false, null, false, null, "ASTROWORLD", false, null, false, null, false, null, false, null, new DateTime(2020, 9, 26, 13, 50, 20, 270, DateTimeKind.Utc).AddTicks(2901), "TRAVIS SCOTT", null, "7DF74B2D-5189-4622-BD09-FE6337C18C3D" },
                    { new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"), "I HATE BEING", true, "LOL", false, null, false, null, false, null, true, "HA", true, "AWESOME", true, "IT'S", true, "BIPOLAR", "PSYCHO", false, null, false, null, false, null, false, null, new DateTime(2020, 9, 26, 13, 50, 20, 270, DateTimeKind.Utc).AddTicks(3086), "KANYE WEST", null, "7DF74B2D-5189-4622-BD09-FE6337C18C3D" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ac7e2eb6-ffb3-4f9e-bbda-1574c07f47bc"), "RAP" },
                    { new Guid("6a179fe5-db82-4cf2-b529-00359bf5b99d"), "POP" },
                    { new Guid("6d067807-2076-4c1f-9e2b-1d766e8bef2c"), "ROCK" },
                    { new Guid("2bf21f1c-ed7a-4943-a844-7eb7ddc66447"), "JAZZ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "7DF74B2D-5189-4622-BD09-FE6337C18C3D", "1E2EFB41-DAA4-4643-9E94-418D05609F57" },
                    { "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda", "02d962c8-3531-41e9-bf0f-bdf29fb0b745" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "FirstCheckBox", "FirstDate", "FirstNumber", "FirstText", "SecondCheckBox", "SecondDate", "SecondNumber", "SecondText", "Theme", "ThirdCheckBox", "ThirdDate", "ThirdNumber", "ThirdText", "TimeAdded", "Title", "TitleImage", "UserId" },
                values: new object[,]
                {
                    { new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"), new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), false, new DateTime(2020, 9, 26, 16, 50, 20, 270, DateTimeKind.Local).AddTicks(9755), 1000.0, "DON'T YOU OPEN UP THE WINDOW", false, null, null, null, "FIRST", false, null, null, null, new DateTime(2020, 9, 26, 13, 50, 20, 270, DateTimeKind.Utc).AddTicks(7422), "TRAVIS", null, "7DF74B2D-5189-4622-BD09-FE6337C18C3D" },
                    { new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"), new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"), false, new DateTime(2020, 9, 26, 16, 50, 20, 272, DateTimeKind.Local).AddTicks(6727), 1000.0, "DON'T YOU LET OUT THE ANTIDOTE", false, null, null, null, "SECOND", false, null, null, null, new DateTime(2020, 9, 26, 13, 50, 20, 272, DateTimeKind.Utc).AddTicks(6586), "SECOND ITEM", null, "7DF74B2D-5189-4622-BD09-FE6337C18C3D" },
                    { new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"), new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"), true, null, null, null, false, new DateTime(2020, 9, 26, 16, 50, 20, 272, DateTimeKind.Local).AddTicks(8516), 10000000.0, "STRAIGHT UP", "THIRD", false, null, null, null, new DateTime(2020, 9, 26, 13, 50, 20, 272, DateTimeKind.Utc).AddTicks(6752), "THIRD ITEM", null, "7DF74B2D-5189-4622-BD09-FE6337C18C3D" }
                });

            migrationBuilder.InsertData(
                table: "ItemTag",
                columns: new[] { "ItemId", "TagId" },
                values: new object[,]
                {
                    { new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"), new Guid("ac7e2eb6-ffb3-4f9e-bbda-1574c07f47bc") },
                    { new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"), new Guid("6a179fe5-db82-4cf2-b529-00359bf5b99d") },
                    { new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"), new Guid("6d067807-2076-4c1f-9e2b-1d766e8bef2c") },
                    { new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"), new Guid("2bf21f1c-ed7a-4943-a844-7eb7ddc66447") }
                });
        }
    }
}
