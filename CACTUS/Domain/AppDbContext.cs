using CACTUS.Domain.Entities;
using CACTUS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                Name = "user",
                NormalizedName = "USER"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "123@mail.ru",
                NormalizedEmail = "123@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "adminpassword"),
                SecurityStamp = String.Empty,
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "oc@yandex.by",
                NormalizedEmail = "OC@YANDEX.BY",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "userpassword"),
                SecurityStamp = String.Empty,
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                UserId = "9a0136a4-5b7a-41ac-b9d9-0556dbd09eda",
            });

            base.OnModelCreating(builder);

            builder.Entity<Like>()
                .HasKey(l => new { l.ItemId, l.UserId });

            builder.Entity<Item>()
                .HasOne(i => i.Collection)
                .WithMany(c => c.Items)
                .HasForeignKey(i => i.CollectionId);

            builder.Entity<ItemTag>()
                .HasKey(k => new { k.ItemId, k.TagId });

            builder.Entity<ItemTag>()
                .HasOne(it => it.Item)
                .WithMany(i => i.ItemTags)
                .HasForeignKey(it => it.ItemId);

            builder.Entity<ItemTag>()
                .HasOne(it => it.Tag)
                .WithMany(i => i.ItemTags)
                .HasForeignKey(it => it.TagId);

            builder.Entity<Collection>().HasData(new Collection
            {
                Id = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                Title = "SLIM SHADY",
                Theme = "OLD SCHOOL",
                Description = "LALALA",
                FirstTextIsEnabled = true,
                FirstTextName = "MY NAME IS",
                FirstNumberIsEnabled = true,
                FirstNumberName = "HUH?",
                FirstDateIsEnabled = true,
                FirstDateName = "SLIM SHADY",
                FirstCheckBoxIsEnabled = true, 
                FirstCheckBoxName = "LOL", 
            });

            builder.Entity<Collection>().HasData(new Collection
            {
                Id = new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                Title = "TRAVIS SCOTT",
                Theme = "ASTROWORLD",
                Description = "ITS LIT",
                FirstTextIsEnabled = true,
                FirstTextName = "AAAAAAAA",
                FirstNumberIsEnabled = true,
                FirstNumberName = "HABABAGAGAGA",
                FirstDateIsEnabled = true,
                FirstDateName = "FFFFFFFFFFFF",
                FirstCheckBoxIsEnabled = true,
                FirstCheckBoxName = "SSSSS",
            });

            builder.Entity<Collection>().HasData(new Collection
            {
                Id = new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                Title = "KANYE WEST",
                Theme = "PSYCHO",
                Description = "I HATE BEING",
                SecondTextIsEnabled = true,
                SecondTextName = "BIPOLAR",
                SecondNumberIsEnabled = true,
                SecondNumberName = "IT'S",
                SecondDateIsEnabled = true,
                SecondDateName = "AWESOME",
                FirstCheckBoxIsEnabled = true,
                SecondCheckBoxIsEnabled = true,
                FirstCheckBoxName = "LOL", 
                SecondCheckBoxName = "HA",
            });

            var firstItem = new Item
            {
                Id = new Guid("61BDD256-5B8E-4DB5-958C-601EA4D2EDA1"),
                UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                CollectionId = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                Title = "TRAVIS",
                Theme = "FIRST",
                FirstText = "DON'T YOU OPEN UP THE WINDOW",
                FirstNumber = 1000,
                FirstCheckBox = false,
                FirstDate = DateTime.Now,
            };
            var secondItem = new Item
            {
                Id = new Guid("3246A17E-A59D-42D6-8A26-CD4BF84F8612"),
                UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                CollectionId = new Guid("c0b297f8-367b-4465-b7b1-0dbcc470ad7a"),
                Title = "SECOND ITEM",
                Theme = "SECOND",
                FirstText = "DON'T YOU LET OUT THE ANTIDOTE",
                FirstNumber = 1000,
                FirstCheckBox = false,
                FirstDate = DateTime.Now,
            };
            var thirdItem = new Item
            {
                Id = new Guid("19E19E85-8CA7-4EB4-8DC9-63E70C93A47F"),
                UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                CollectionId = new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                Title = "THIRD ITEM",
                Theme = "THIRD",
                SecondText = "STRAIGHT UP",
                SecondNumber = 10000000,
                FirstCheckBox = true,
                SecondCheckBox = false,
                SecondDate = DateTime.Now,
            };

            var firstTag = new Tag
            {
                Id = new Guid("ac7e2eb6-ffb3-4f9e-bbda-1574c07f47bc"),
                Name = "RAP",
            };
            var secondTag = new Tag
            {
                Id = new Guid("6a179fe5-db82-4cf2-b529-00359bf5b99d"),
                Name = "POP",
            };
            var thirdTag = new Tag
            {
                Id = new Guid("6d067807-2076-4c1f-9e2b-1d766e8bef2c"),
                Name = "ROCK",
            };
            var fourthTag = new Tag
            {
                Id = new Guid("2bf21f1c-ed7a-4943-a844-7eb7ddc66447"),
                Name = "JAZZ",
            };

            var itemTag1 = new ItemTag { ItemId = firstItem.Id, TagId = firstTag.Id };
            var itemTag2 = new ItemTag { ItemId = secondItem.Id, TagId = secondTag.Id };
            var itemTag3 = new ItemTag { ItemId = thirdItem.Id, TagId = thirdTag.Id };
            var itemTag4 = new ItemTag { ItemId = thirdItem.Id, TagId = fourthTag.Id };

            builder.Entity<Item>().HasData(firstItem);
            builder.Entity<Item>().HasData(secondItem);
            builder.Entity<Item>().HasData(thirdItem);

            builder.Entity<Tag>().HasData(firstTag);
            builder.Entity<Tag>().HasData(secondTag);
            builder.Entity<Tag>().HasData(thirdTag);
            builder.Entity<Tag>().HasData(fourthTag);

            builder.Entity<ItemTag>().HasData(itemTag1);
            builder.Entity<ItemTag>().HasData(itemTag2);
            builder.Entity<ItemTag>().HasData(itemTag3);
            builder.Entity<ItemTag>().HasData(itemTag4);
        }
    }
}
