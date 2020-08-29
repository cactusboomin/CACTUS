﻿// <auto-generated />
using System;
using CACTUS.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CACTUS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200828142922__restart")]
    partial class _restart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
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

                    b.Property<string>("TitleImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

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
                            TimeAdded = new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(721),
                            Title = "SLIM SHADY",
                            TitleImagePath = "~/images/slimshady.jpg",
                            UserId = new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d")
                        },
                        new
                        {
                            Id = new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                            Description = "ITS LIT",
                            FirstCheckBoxIsEnabled = true,
                            FirstCheckBoxName = "FFFFF",
                            FirstDateIsEnabled = true,
                            FirstDateName = "AAAAAAAAAAAAAAAAAAAA",
                            FirstNumberIsEnabled = true,
                            FirstNumberName = "HASGASG?",
                            FirstTextIsEnabled = true,
                            FirstTextName = "ALFKASLF",
                            SecondCheckBoxIsEnabled = false,
                            SecondDateIsEnabled = false,
                            SecondNumberIsEnabled = false,
                            SecondTextIsEnabled = false,
                            Theme = "ASTROWORLD",
                            ThirdCheckBoxIsEnabled = false,
                            ThirdDateIsEnabled = false,
                            ThirdNumberIsEnabled = false,
                            ThirdTextIsEnabled = false,
                            TimeAdded = new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(8222),
                            Title = "TRAVIS SCOTT",
                            TitleImagePath = "~/images/travisscott.jpg",
                            UserId = new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d")
                        },
                        new
                        {
                            Id = new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                            Description = "I HATE BEING",
                            FirstCheckBoxIsEnabled = true,
                            FirstCheckBoxName = "LOL",
                            FirstDateIsEnabled = true,
                            FirstDateName = "AWESOME",
                            FirstNumberIsEnabled = true,
                            FirstNumberName = "IT'S",
                            FirstTextIsEnabled = true,
                            FirstTextName = "BIPOLAR",
                            SecondCheckBoxIsEnabled = false,
                            SecondDateIsEnabled = false,
                            SecondNumberIsEnabled = false,
                            SecondTextIsEnabled = false,
                            Theme = "PSYCHO",
                            ThirdCheckBoxIsEnabled = false,
                            ThirdDateIsEnabled = false,
                            ThirdNumberIsEnabled = false,
                            ThirdTextIsEnabled = false,
                            TimeAdded = new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(8462),
                            Title = "KANYE WEST",
                            TitleImagePath = "~/images/kanyewest.jpg",
                            UserId = new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d")
                        });
                });

            modelBuilder.Entity("CACTUS.Domain.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CollectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("FirstCheckBox")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FirstDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("FirstNumber")
                        .HasColumnType("float");

                    b.Property<string>("FirstText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SecondCheckBox")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SecondDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("SecondNumber")
                        .HasColumnType("float");

                    b.Property<string>("SecondText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ThirdCheckBox")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ThirdDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ThirdNumber")
                        .HasColumnType("float");

                    b.Property<string>("ThirdText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = new Guid("61bdd256-5b8e-4db5-958c-601ea4d2eda1"),
                            CollectionId = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                            FirstCheckBox = false,
                            FirstDate = new DateTime(2020, 8, 28, 17, 29, 21, 592, DateTimeKind.Local).AddTicks(1108),
                            FirstNumber = 1000.0,
                            FirstText = "DON'T YOU OPEN UP THE WINDOW",
                            SecondCheckBox = false,
                            SecondDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondNumber = 0.0,
                            Theme = "FIRST",
                            ThirdCheckBox = false,
                            ThirdDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThirdNumber = 0.0,
                            TimeAdded = new DateTime(2020, 8, 28, 14, 29, 21, 591, DateTimeKind.Utc).AddTicks(9117),
                            Title = "FIRST ITEM",
                            UserId = new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d")
                        },
                        new
                        {
                            Id = new Guid("3246a17e-a59d-42d6-8a26-cd4bf84f8612"),
                            CollectionId = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                            FirstCheckBox = true,
                            FirstDate = new DateTime(2020, 8, 28, 17, 29, 21, 593, DateTimeKind.Local).AddTicks(4475),
                            FirstNumber = 2000.0,
                            FirstText = "DON'T YOU LET OUT THE ANTIDOTE",
                            SecondCheckBox = false,
                            SecondDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondNumber = 0.0,
                            Theme = "SECOND",
                            ThirdCheckBox = false,
                            ThirdDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThirdNumber = 0.0,
                            TimeAdded = new DateTime(2020, 8, 28, 14, 29, 21, 593, DateTimeKind.Utc).AddTicks(4399),
                            Title = "SECOND ITEM",
                            UserId = new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d")
                        },
                        new
                        {
                            Id = new Guid("19e19e85-8ca7-4eb4-8dc9-63e70c93a47f"),
                            CollectionId = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                            FirstCheckBox = false,
                            FirstDate = new DateTime(2020, 8, 28, 17, 29, 21, 593, DateTimeKind.Local).AddTicks(4548),
                            FirstNumber = 3000.0,
                            FirstText = "STRAIGHT UP",
                            SecondCheckBox = false,
                            SecondDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondNumber = 0.0,
                            Theme = "THIRD",
                            ThirdCheckBox = false,
                            ThirdDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThirdNumber = 0.0,
                            TimeAdded = new DateTime(2020, 8, 28, 14, 29, 21, 593, DateTimeKind.Utc).AddTicks(4538),
                            Title = "THIRD ITEM",
                            UserId = new Guid("7df74b2d-5189-4622-bd09-fe6337c18c3d")
                        });
                });

            modelBuilder.Entity("CACTUS.Domain.Entities.ServiceItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ServiceItems");
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
                            Id = new Guid("9c1f89ac-1302-4ce8-b364-1cb5046ca27c"),
                            Name = "RAP"
                        },
                        new
                        {
                            Id = new Guid("a1ccfdf9-be71-4428-a644-cbc51cb5a101"),
                            Name = "POP"
                        },
                        new
                        {
                            Id = new Guid("3169a29e-9fce-4f01-b9c0-05b3d3d5a20a"),
                            Name = "POP"
                        });
                });

            modelBuilder.Entity("CACTUS.Domain.Entities.TextField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TextFields");
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
                            ConcurrencyStamp = "399c8d9b-9c1b-4fdb-b85a-0166667d2ed0",
                            Name = "admin",
                            NormalizedName = "ADMIN"
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
                            ConcurrencyStamp = "36fc8efe-7993-479f-8cfb-3fa82a2f58d4",
                            Email = "123@mail.ru",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "123@MAIL.RU",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEA7fLz3GfwnNRH1+5bbc/hYJhwyjhhGf7GbVbZVHMQMzlP3WdNqjLAjBZGxNSiCZBQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
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