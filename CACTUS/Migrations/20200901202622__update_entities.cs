using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CACTUS.Migrations
{
    public partial class _update_entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Items_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1E2EFB41-DAA4-4643-9E94-418D05609F57", "9e9e6223-bb3a-445c-9e29-5d25e3cf96a1", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7DF74B2D-5189-4622-BD09-FE6337C18C3D", 0, "272cb6f8-593c-4305-b01b-1796e5628d2e", "123@mail.ru", true, false, null, "123@MAIL.RU", "ADMIN", "AQAAAAEAACcQAAAAEB1b8CywfaT5CjsLF9CRiroZfYDS9NGKX/wbj9AE+byaH/CDHbNs9w64xtixzlXrlQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "FirstCheckBoxIsEnabled", "FirstCheckBoxName", "FirstDateIsEnabled", "FirstDateName", "FirstNumberIsEnabled", "FirstNumberName", "FirstTextIsEnabled", "FirstTextName", "SecondCheckBoxIsEnabled", "SecondCheckBoxName", "SecondDateIsEnabled", "SecondDateName", "SecondNumberIsEnabled", "SecondNumberName", "SecondTextIsEnabled", "SecondTextName", "Theme", "ThirdCheckBoxIsEnabled", "ThirdCheckBoxName", "ThirdDateIsEnabled", "ThirdDateName", "ThirdNumberIsEnabled", "ThirdNumberName", "ThirdTextIsEnabled", "ThirdTextName", "TimeAdded", "Title", "TitleImagePath", "UserId" },
                values: new object[,]
                {
                    { new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), "LALALA", true, "LOL", true, "SLIM SHADY", true, "HUH?", true, "MY NAME IS", false, null, false, null, false, null, false, null, "OLD SCHOOL", false, null, false, null, false, null, false, null, new DateTime(2020, 9, 1, 20, 26, 21, 866, DateTimeKind.Utc).AddTicks(1573), "SLIM SHADY", "images/slimshady.jpg", new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") },
                    { new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"), "ITS LIT", true, "FFFFF", true, "AAAAAAAAAAAAAAAAAAAA", true, "HASGASG?", true, "ALFKASLF", false, null, false, null, false, null, false, null, "ASTROWORLD", false, null, false, null, false, null, false, null, new DateTime(2020, 9, 1, 20, 26, 21, 867, DateTimeKind.Utc).AddTicks(1099), "TRAVIS SCOTT", "images/travisscott.jpg", new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") },
                    { new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"), "I HATE BEING", true, "LOL", true, "AWESOME", true, "IT'S", true, "BIPOLAR", false, null, false, null, false, null, false, null, "PSYCHO", false, null, false, null, false, null, false, null, new DateTime(2020, 9, 1, 20, 26, 21, 867, DateTimeKind.Utc).AddTicks(1441), "KANYE WEST", "images/kanyewest.jpg", new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") }
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
                values: new object[] { "7DF74B2D-5189-4622-BD09-FE6337C18C3D", "1E2EFB41-DAA4-4643-9E94-418D05609F57" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "FirstCheckBox", "FirstDate", "FirstNumber", "FirstText", "SecondCheckBox", "SecondDate", "SecondNumber", "SecondText", "Theme", "ThirdCheckBox", "ThirdDate", "ThirdNumber", "ThirdText", "TimeAdded", "Title", "TitleImagePath", "UserId" },
                values: new object[,]
                {
                    { new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"), new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), false, new DateTime(2020, 9, 1, 23, 26, 21, 867, DateTimeKind.Local).AddTicks(4660), 1000.0, "DON'T YOU OPEN UP THE WINDOW", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, "FIRST", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, new DateTime(2020, 9, 1, 20, 26, 21, 867, DateTimeKind.Utc).AddTicks(2115), "TRAVIS", null, new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") },
                    { new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"), new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), true, new DateTime(2020, 9, 1, 23, 26, 21, 869, DateTimeKind.Local).AddTicks(1555), 2000.0, "DON'T YOU LET OUT THE ANTIDOTE", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, "SECOND", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, new DateTime(2020, 9, 1, 20, 26, 21, 869, DateTimeKind.Utc).AddTicks(1450), "SECOND ITEM", null, new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") },
                    { new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"), new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"), false, new DateTime(2020, 9, 1, 23, 26, 21, 869, DateTimeKind.Local).AddTicks(1630), 3000.0, "STRAIGHT UP", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, "THIRD", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, null, new DateTime(2020, 9, 1, 20, 26, 21, 869, DateTimeKind.Utc).AddTicks(1620), "THIRD ITEM", null, new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CollectionId",
                table: "Items",
                column: "CollectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Collections");
        }
    }
}
