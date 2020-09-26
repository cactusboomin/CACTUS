using CACTUS.Domain.Entities;
using CACTUS.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.EntityFramework
{
    public class EFCommentsRepository : ICommentsRepository
    {
        private AppDbContext context;

        public EFCommentsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddComment(string userId, Guid itemId, string text)
        {
            this.context.Comments.Add(new Comment
            {
                UserId = userId, 
                ItemId = itemId,
                Text = text
            });

            this.context.SaveChanges();
        }

        public void DeleteComment(Guid commentId)
        {
            this.context.Comments.Remove(new Comment { CommentId = commentId });

            this.context.SaveChanges();
        }

        public IQueryable<Comment> GetComments(Guid itemId)
        {
            return this.context.Comments.Where(c => c.ItemId == itemId) ?? new List<Comment>().AsQueryable();
        }
    }
}
