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

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("61BDD256-5B8E-4DB5-958C-601EA4D2EDA1"),
                CodeWord = "PageIndex",
                Description = "Main page",
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("3246A17E-A59D-42D6-8A26-CD4BF84F8612"),
                CodeWord = "PageServices",
                Description = "Services",
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("19E19E85-8CA7-4EB4-8DC9-63E70C93A47F"),
                CodeWord = "PageContacts",
                Description = "Contacts",
            });
        }
    }
}
