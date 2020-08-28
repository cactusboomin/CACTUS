using CACTUS.Domain.Entities;
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
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "7DF74B2D-5189-4622-BD09-FE6337C18C3D",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "123@mail.ru",
                NormalizedEmail = "123@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = String.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1E2EFB41-DAA4-4643-9E94-418D05609F57",
                UserId = "7DF74B2D-5189-4622-BD09-FE6337C18C3D"
            });

            builder.Entity<Collection>().HasData(new Collection
            {
                Id = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                UserId = new Guid("7DF74B2D-5189-4622-BD09-FE6337C18C3D"),
                Title = "SLIM SHADY",
                TitleImagePath = "images/slimshady.jpg",
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
                UserId = new Guid("7DF74B2D-5189-4622-BD09-FE6337C18C3D"),
                Title = "TRAVIS SCOTT",
                TitleImagePath = "images/travisscott.jpg",
                Theme = "ASTROWORLD",
                Description = "ITS LIT",
                FirstTextIsEnabled = true,
                FirstTextName = "ALFKASLF",
                FirstNumberIsEnabled = true,
                FirstNumberName = "HASGASG?",
                FirstDateIsEnabled = true,
                FirstDateName = "AAAAAAAAAAAAAAAAAAAA",
                FirstCheckBoxIsEnabled = true,
                FirstCheckBoxName = "FFFFF",
            });

            builder.Entity<Collection>().HasData(new Collection
            {
                Id = new Guid("b5306fba-e436-4d49-a902-2ce1d01002b8"),
                UserId = new Guid("7DF74B2D-5189-4622-BD09-FE6337C18C3D"),
                Title = "KANYE WEST",
                TitleImagePath = "images/kanyewest.jpg",
                Theme = "PSYCHO",
                Description = "I HATE BEING",
                FirstTextIsEnabled = true,
                FirstTextName = "BIPOLAR",
                FirstNumberIsEnabled = true,
                FirstNumberName = "IT'S",
                FirstDateIsEnabled = true,
                FirstDateName = "AWESOME",
                FirstCheckBoxIsEnabled = true,
                FirstCheckBoxName = "LOL",
            });

            builder.Entity<Item>().HasData(new Item
            {
                Id = new Guid("61BDD256-5B8E-4DB5-958C-601EA4D2EDA1"),
                UserId = new Guid("7DF74B2D-5189-4622-BD09-FE6337C18C3D"),
                CollectionId = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                Title = "FIRST ITEM",
                Theme = "FIRST",
                FirstText = "DON'T YOU OPEN UP THE WINDOW",
                FirstNumber = 1000,
                FirstCheckBox = false,
                FirstDate = DateTime.Now,
            });

            builder.Entity<Item>().HasData(new Item
            {
                Id = new Guid("3246A17E-A59D-42D6-8A26-CD4BF84F8612"),
                UserId = new Guid("7DF74B2D-5189-4622-BD09-FE6337C18C3D"),
                CollectionId = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                Title = "SECOND ITEM",
                Theme = "SECOND",
                FirstText = "DON'T YOU LET OUT THE ANTIDOTE",
                FirstNumber = 2000,
                FirstCheckBox = true,
                FirstDate = DateTime.Now,
            });

            builder.Entity<Item>().HasData(new Item
            {
                Id = new Guid("19E19E85-8CA7-4EB4-8DC9-63E70C93A47F"),
                UserId = new Guid("7DF74B2D-5189-4622-BD09-FE6337C18C3D"),
                CollectionId = new Guid("48cca082-152c-43df-96f2-7a6345b11cbd"),
                Title = "THIRD ITEM",
                Theme = "THIRD",
                FirstText = "STRAIGHT UP",
                FirstNumber = 3000,
                FirstCheckBox = false,
                FirstDate = DateTime.Now,
            });

            builder.Entity<Tag>().HasData(new Tag
            {
                Id = new Guid("9c1f89ac-1302-4ce8-b364-1cb5046ca27c"),
                Name = "RAP",
            });

            builder.Entity<Tag>().HasData(new Tag
            {
                Id = new Guid("a1ccfdf9-be71-4428-a644-cbc51cb5a101"),
                Name = "POP",
            });

            builder.Entity<Tag>().HasData(new Tag
            {
                Id = new Guid("3169a29e-9fce-4f01-b9c0-05b3d3d5a20a"),
                Name = "ROCK",
            });

            builder.Entity<Tag>().HasData(new Tag
            {
                Id = new Guid("c21c3eb9-810b-43b5-98da-69f1edb6edd3"),
                Name = "JAZZ",
            });

            builder.Entity<Tag>().HasData(new Tag
            {
                Id = new Guid("3e892139-3de4-490e-9ffe-e5580824a69c"),
                Name = "PUNK",
            });

            builder.Entity<Tag>().HasData(new Tag
            {
                Id = new Guid("7ca274a2-b712-432d-9c6d-06fa36e4d444"),
                Name = "METAL",
            });
        }
    }
}
