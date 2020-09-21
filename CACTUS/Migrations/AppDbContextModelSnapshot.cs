﻿// <auto-generated />
using System;
using CACTUS.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CACTUS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CACTUS.Domain.Entities.Collection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FirstCheckBoxIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("FirstCheckBoxName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FirstDateIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("FirstDateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FirstNumberIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("FirstNumberName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FirstTextIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("FirstTextName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SecondCheckBoxIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("SecondCheckBoxName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SecondDateIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("SecondDateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SecondNumberIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("SecondNumberName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SecondTextIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("SecondTextName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ThirdCheckBoxIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("ThirdCheckBoxName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ThirdDateIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("ThirdDateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ThirdNumberIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("ThirdNumberName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ThirdTextIsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("ThirdTextName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TitleImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Collections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                            Description = "LALALA",
                            FirstCheckBoxIsEnabled = true,
                            FirstCheckBoxName = "LOL",
                            FirstDateIsEnabled = true,
                            FirstDateName = "SLIM SHADY",
                            FirstNumberIsEnabled = true,
                            FirstNumberName = "HUH?",
                            FirstTextIsEnabled = true,
                            FirstTextName = "MY NAME IS",
                            SecondCheckBoxIsEnabled = false,
                            SecondDateIsEnabled = false,
                            SecondNumberIsEnabled = false,
                            SecondTextIsEnabled = false,
                            Theme = "OLD SCHOOL",
                            ThirdCheckBoxIsEnabled = false,
                            ThirdDateIsEnabled = false,
                            ThirdNumberIsEnabled = false,
                            ThirdTextIsEnabled = false,
                            TimeAdded = new DateTime(2020, 9, 21, 18, 53, 18, 601, DateTimeKind.Utc).AddTicks(7922),
                            Title = "SLIM SHADY",
                            UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D"
                        },
                        new
                        {
                            Id = new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                            Description = "ITS LIT",
                            FirstCheckBoxIsEnabled = true,
                            FirstCheckBoxName = "SSSSS",
                            FirstDateIsEnabled = true,
                            FirstDateName = "FFFFFFFFFFFF",
                            FirstNumberIsEnabled = true,
                            FirstNumberName = "HABABAGAGAGA",
                            FirstTextIsEnabled = true,
                            FirstTextName = "AAAAAAAA",
                            SecondCheckBoxIsEnabled = false,
                            SecondDateIsEnabled = false,
                            SecondNumberIsEnabled = false,
                            SecondTextIsEnabled = false,
                            Theme = "ASTROWORLD",
                            ThirdCheckBoxIsEnabled = false,
                            ThirdDateIsEnabled = false,
                            ThirdNumberIsEnabled = false,
                            ThirdTextIsEnabled = false,
                            TimeAdded = new DateTime(2020, 9, 21, 18, 53, 18, 602, DateTimeKind.Utc).AddTicks(5671),
                            Title = "TRAVIS SCOTT",
                            UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D"
                        },
                        new
                        {
                            Id = new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                            Description = "I HATE BEING",
                            FirstCheckBoxIsEnabled = true,
                            FirstCheckBoxName = "LOL",
                            FirstDateIsEnabled = false,
                            FirstNumberIsEnabled = false,
                            FirstTextIsEnabled = false,
                            SecondCheckBoxIsEnabled = true,
                            SecondCheckBoxName = "HA",
                            SecondDateIsEnabled = true,
                            SecondDateName = "AWESOME",
                            SecondNumberIsEnabled = true,
                            SecondNumberName = "IT'S",
                            SecondTextIsEnabled = true,
                            SecondTextName = "BIPOLAR",
                            Theme = "PSYCHO",
                            ThirdCheckBoxIsEnabled = false,
                            ThirdDateIsEnabled = false,
                            ThirdNumberIsEnabled = false,
                            ThirdTextIsEnabled = false,
                            TimeAdded = new DateTime(2020, 9, 21, 18, 53, 18, 602, DateTimeKind.Utc).AddTicks(5856),
                            Title = "KANYE WEST",
                            UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D"
                        });
                });

            modelBuilder.Entity("CACTUS.Domain.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CollectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("FirstCheckBox")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FirstDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("FirstNumber")
                        .HasColumnType("float");

                    b.Property<string>("FirstText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SecondCheckBox")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("SecondDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("SecondNumber")
                        .HasColumnType("float");

                    b.Property<string>("SecondText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ThirdCheckBox")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ThirdDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("ThirdNumber")
                        .HasColumnType("float");

                    b.Property<string>("ThirdText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TitleImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                            CollectionId = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                            FirstCheckBox = false,
                            FirstDate = new DateTime(2020, 9, 21, 21, 53, 18, 603, DateTimeKind.Local).AddTicks(2542),
                            FirstNumber = 1000.0,
                            FirstText = "DON'T YOU OPEN UP THE WINDOW",
                            Theme = "FIRST",
                            TimeAdded = new DateTime(2020, 9, 21, 18, 53, 18, 603, DateTimeKind.Utc).AddTicks(303),
                            Title = "TRAVIS",
                            UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D"
                        },
                        new
                        {
                            Id = new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                            CollectionId = new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                            FirstCheckBox = false,
                            FirstDate = new DateTime(2020, 9, 21, 21, 53, 18, 604, DateTimeKind.Local).AddTicks(5253),
                            FirstNumber = 1000.0,
                            FirstText = "DON'T YOU LET OUT THE ANTIDOTE",
                            Theme = "SECOND",
                            TimeAdded = new DateTime(2020, 9, 21, 18, 53, 18, 604, DateTimeKind.Utc).AddTicks(5149),
                            Title = "SECOND ITEM",
                            UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D"
                        },
                        new
                        {
                            Id = new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                            CollectionId = new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                            FirstCheckBox = true,
                            SecondCheckBox = false,
                            SecondDate = new DateTime(2020, 9, 21, 21, 53, 18, 604, DateTimeKind.Local).AddTicks(7095),
                            SecondNumber = 10000000.0,
                            SecondText = "STRAIGHT UP",
                            Theme = "THIRD",
                            TimeAdded = new DateTime(2020, 9, 21, 18, 53, 18, 604, DateTimeKind.Utc).AddTicks(5276),
                            Title = "THIRD ITEM",
                            UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D"
                        });
                });

            modelBuilder.Entity("CACTUS.Domain.Entities.ItemTag", b =>
                {
                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ItemTag");

                    b.HasData(
                        new
                        {
                            ItemId = new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                            TagId = new Guid("ac7e2eb6-ffb3-4f9e-bbda-1574c07f47bc")
                        },
                        new
                        {
                            ItemId = new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                            TagId = new Guid("6a179fe5-db82-4cf2-b529-00359bf5b99d")
                        },
                        new
                        {
                            ItemId = new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                            TagId = new Guid("6d067807-2076-4c1f-9e2b-1d766e8bef2c")
                        },
                        new
                        {
                            ItemId = new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                            TagId = new Guid("2bf21f1c-ed7a-4943-a844-7eb7ddc66447")
                        });
                });

            modelBuilder.Entity("CACTUS.Domain.Entities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac7e2eb6-ffb3-4f9e-bbda-1574c07f47bc"),
                            Name = "RAP"
                        },
                        new
                        {
                            Id = new Guid("6a179fe5-db82-4cf2-b529-00359bf5b99d"),
                            Name = "POP"
                        },
                        new
                        {
                            Id = new Guid("6d067807-2076-4c1f-9e2b-1d766e8bef2c"),
                            Name = "ROCK"
                        },
                        new
                        {
                            Id = new Guid("2bf21f1c-ed7a-4943-a844-7eb7ddc66447"),
                            Name = "JAZZ"
                        });
                });

            modelBuilder.Entity("CACTUS.Models.FileModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                            ConcurrencyStamp = "a3202ce1-d34c-4ae9-9d60-87c577cf79ef",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                            ConcurrencyStamp = "33226f40-3805-4297-96ed-77dc6a4f82f5",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cfb4dbc0-92f4-44ed-a913-93bc31e1adb7",
                            Email = "123@mail.ru",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "123@MAIL.RU",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEN/suX4onyhSSJQaP40KmjF0oY0t/QEY57Az8yoS8NRUS+CTx/DUPEc3zISQlbTBLg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "31f704e6-3d4c-4688-8973-393a97808c06",
                            Email = "oc@yandex.by",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "OC@YANDEX.BY",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAENucXDC03g31aw5Kxq5GkbYl0m3hnB5tFn5Y1NPE9DXEnuXBzvMRQN5uXOEz+nzgvg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                            RoleId = "1E2EFB41-DAA4-4643-9E94-418D05609F57"
                        },
                        new
                        {
                            UserId = "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                            RoleId = "02d962c8-3531-41e9-bf0f-bdf29fb0b745"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CACTUS.Domain.Entities.Item", b =>
                {
                    b.HasOne("CACTUS.Domain.Entities.Collection", "Collection")
                        .WithMany("Items")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CACTUS.Domain.Entities.ItemTag", b =>
                {
                    b.HasOne("CACTUS.Domain.Entities.Item", "Item")
                        .WithMany("ItemTags")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CACTUS.Domain.Entities.Tag", "Tag")
                        .WithMany("ItemTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
