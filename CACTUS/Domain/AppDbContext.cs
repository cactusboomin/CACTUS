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
        }
    }
}
