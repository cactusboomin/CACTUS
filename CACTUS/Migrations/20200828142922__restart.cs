using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class _restart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"));

            migrationBuilder.DropColumn(
                name: "CodeWord",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "ServiceItems");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TextFields",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Theme",
                table: "TextFields",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "TextFields",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Theme",
                table: "ServiceItems",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ServiceItems",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Theme = table.Column<string>(nullable: false),
                    TitleImagePath = table.Column<string>(nullable: true),
                    TimeAdded = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    FirstNumberIsEnabled = table.Column<bool>(nullable: false),
                    FirstNumberName = table.Column<string>(nullable: true),
                    SecondNumberIsEnabled = table.Column<bool>(nullable: false),
                    SecondNumberName = table.Column<string>(nullable: true),
                    ThirdNumberIsEnabled = table.Column<bool>(nullable: false),
                    ThirdNumberName = table.Column<string>(nullable: true),
                    FirstTextIsEnabled = table.Column<bool>(nullable: false),
                    FirstTextName = table.Column<string>(nullable: true),
                    SecondTextIsEnabled = table.Column<bool>(nullable: false),
                    SecondTextName = table.Column<string>(nullable: true),
                    ThirdTextIsEnabled = table.Column<bool>(nullable: false),
                    ThirdTextName = table.Column<string>(nullable: true),
                    FirstDateIsEnabled = table.Column<bool>(nullable: false),
                    FirstDateName = table.Column<string>(nullable: true),
                    SecondDateIsEnabled = table.Column<bool>(nullable: false),
                    SecondDateName = table.Column<string>(nullable: true),
                    ThirdDateIsEnabled = table.Column<bool>(nullable: false),
                    ThirdDateName = table.Column<string>(nullable: true),
                    FirstCheckBoxIsEnabled = table.Column<bool>(nullable: false),
                    FirstCheckBoxName = table.Column<string>(nullable: true),
                    SecondCheckBoxIsEnabled = table.Column<bool>(nullable: false),
                    SecondCheckBoxName = table.Column<string>(nullable: true),
                    ThirdCheckBoxIsEnabled = table.Column<bool>(nullable: false),
                    ThirdCheckBoxName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Theme = table.Column<string>(nullable: false),
                    TitleImagePath = table.Column<string>(nullable: true),
                    TimeAdded = table.Column<DateTime>(nullable: false),
                    CollectionId = table.Column<Guid>(nullable: false),
                    FirstNumber = table.Column<double>(nullable: false),
                    SecondNumber = table.Column<double>(nullable: false),
                    ThirdNumber = table.Column<double>(nullable: false),
                    FirstText = table.Column<string>(nullable: true),
                    SecondText = table.Column<string>(nullable: true),
                    ThirdText = table.Column<string>(nullable: true),
                    FirstDate = table.Column<DateTime>(nullable: false),
                    SecondDate = table.Column<DateTime>(nullable: false),
                    ThirdDate = table.Column<DateTime>(nullable: false),
                    FirstCheckBox = table.Column<bool>(nullable: false),
                    SecondCheckBox = table.Column<bool>(nullable: false),
                    ThirdCheckBox = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "FirstCheckBoxIsEnabled", "FirstCheckBoxName", "FirstDateIsEnabled", "FirstDateName", "FirstNumberIsEnabled", "FirstNumberName", "FirstTextIsEnabled", "FirstTextName", "SecondCheckBoxIsEnabled", "SecondCheckBoxName", "SecondDateIsEnabled", "SecondDateName", "SecondNumberIsEnabled", "SecondNumberName", "SecondTextIsEnabled", "SecondTextName", "Theme", "ThirdCheckBoxIsEnabled", "ThirdCheckBoxName", "ThirdDateIsEnabled", "ThirdDateName", "ThirdNumberIsEnabled", "ThirdNumberName", "ThirdTextIsEnabled", "ThirdTextName", "TimeAdded", "Title", "TitleImagePath", "UserId" },
                values: new object[,]
                {
                    { new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), "LALALA", true, "LOL", true, "SLIM SHADY", true, "HUH?", true, "MY NAME IS", false, null, false, null, false, null, false, null, "OLD SCHOOL", false, null, false, null, false, null, false, null, new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(721), "SLIM SHADY", "~/images/slimshady.jpg", new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") },
                    { new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"), "ITS LIT", true, "FFFFF", true, "AAAAAAAAAAAAAAAAAAAA", true, "HASGASG?", true, "ALFKASLF", false, null, false, null, false, null, false, null, "ASTROWORLD", false, null, false, null, false, null, false, null, new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(8222), "TRAVIS SCOTT", "~/images/travisscott.jpg", new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") },
                    { new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"), "I HATE BEING", true, "LOL", true, "AWESOME", true, "IT'S", true, "BIPOLAR", false, null, false, null, false, null, false, null, "PSYCHO", false, null, false, null, false, null, false, null, new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(8462), "KANYE WEST", "~/images/kanyewest.jpg", new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "FirstCheckBox", "FirstDate", "FirstNumber", "FirstText", "SecondCheckBox", "SecondDate", "SecondNumber", "SecondText", "Theme", "ThirdCheckBox", "ThirdDate", "ThirdNumber", "ThirdText", "TimeAdded", "Title", "TitleImagePath", "UserId" },
                values: new object[,]
                {
                    { new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"), new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), false, new DateTime(2020, 8, 28, 17, 29, 21, 592, DateTimeKind.Local).AddTicks(1108), 1000.0, "DON'T YOU OPEN UP THE WINDOW", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, "FIRST", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(9117), "FIRST ITEM", null, new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") },
                    { new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"), new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), true, new DateTime(2020, 8, 28, 17, 29, 21, 593, DateTimeKind.Local).AddTicks(4475), 2000.0, "DON'T YOU LET OUT THE ANTIDOTE", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, "SECOND", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, new DateTime(2020, 8, 28, 14, 29, 21, 593, DateTimeKind.Utc).AddTicks(4399), "SECOND ITEM", null, new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") },
                    { new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"), new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), false, new DateTime(2020, 8, 28, 17, 29, 21, 593, DateTimeKind.Local).AddTicks(4548), 3000.0, "STRAIGHT UP", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, "THIRD", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, new DateTime(2020, 8, 28, 14, 29, 21, 593, DateTimeKind.Utc).AddTicks(4538), "THIRD ITEM", null, new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9c1f89ac-1302-4ce8-b364-1cb5046ca27c"), "RAP" },
                    { new Guid("a1ccfdf9-be71-4428-a644-cbc51cb5a101"), "POP" },
                    { new Guid("3169a29e-9fce-4f01-b9c0-05b3d3d5a20a"), "POP" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropColumn(
                name: "Theme",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "Theme",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ServiceItems");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "CodeWord",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                column: "ConcurrencyStamp",
                value: "ee75cbae-1a76-4639-87a8-a266b17294bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb8f1537-7e23-4c49-8ef3-8b6f29284246", "AQAAAAEAACcQAAAAEMf8PLSnw/B8lsA3sk8UZvkMpu4dGKtj3HMqMp3FUy6Jd2HOez5JVj7WmXreVwfSBw==" });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "Description", "MetaDescription", "MetaKeywords", "MetaTitle", "TimeAdded", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"), "PageIndex", "Main page", null, null, null, new DateTime(2020, 8, 24, 18, 38, 20, 588, DateTimeKind.Utc).AddTicks(3446), "LALALALA", null },
                    { new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"), "PageServices", "Services", null, null, null, new DateTime(2020, 8, 24, 18, 38, 20, 588, DateTimeKind.Utc).AddTicks(5486), "LALALALA", null },
                    { new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"), "PageContacts", "Contacts", null, null, null, new DateTime(2020, 8, 24, 18, 38, 20, 588, DateTimeKind.Utc).AddTicks(5563), "LALALALA", null }
                });
        }
    }
}
