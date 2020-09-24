using CACTUS.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.Abstract
{
    public interface ILikesRepository
    {
        public IQueryable<Item> GetLikedItems(string userId);
        public IQueryable<IdentityUser> GetUsers(Guid itemId);
        public void Like(string userId, Guid itemId);
        public void Dislike(string userId, Guid itemId);
        public bool HasLike(string userId, Guid itemId);
    }
}
