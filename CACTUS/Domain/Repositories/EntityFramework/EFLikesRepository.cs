using CACTUS.Domain.Repositories.Abstract;
using CACTUS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CACTUS.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CACTUS.Domain.Repositories.EntityFramework
{
    public class EFLikesRepository : ILikesRepository
    {
        private readonly AppDbContext context;

        public EFLikesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Dislike(string userId, Guid itemId)
        {
            this.context.Likes.Remove(new Like { UserId = userId, ItemId = itemId });

            this.context.SaveChanges();
        }

        public IQueryable<Item> GetLikedItems(string userId)
        {
            var items = new List<Item>();
            var likes = this.context.Likes.Where(l => l.UserId == userId);

            foreach (var l in likes)
            {
                var item = this.context.Items.Find(l.ItemId);

                if (item != null)
                {
                    items.Add(item);
                }
            }

            return items.AsQueryable();
        }

        public IQueryable<IdentityUser> GetUsers(Guid itemId)
        {
            var users = new List<IdentityUser>();
            var likes = this.context.Likes.Where(l => l.ItemId == itemId);

            foreach (var l in likes)
            {
                users.Add(l.User);
            }

            return users.AsQueryable();
        }

        public void Like(string userId, Guid itemId)
        {
            this.context.Likes.Add(new Like
            {
                ItemId = itemId,
                UserId = userId,
            });

            this.context.SaveChanges();
        }

        public bool HasLike(string userId, Guid itemId)
        {
            return this.context.Likes.FindAsync(new object[]{ itemId, userId }).Result == null ? false : true;
        }
    }
}
