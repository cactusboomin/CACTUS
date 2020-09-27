using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.Abstract
{
    public interface ICommentsRepository
    {
        void AddComment(string userId, Guid itemId, string text);
        void DeleteComment(Guid commentId);
        IQueryable<Comment> GetComments(Guid itemId);
    }
}
