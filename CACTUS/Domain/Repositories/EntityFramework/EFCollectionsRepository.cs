using CACTUS.Domain.Entities;
using CACTUS.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.EntityFramework
{
    public class EFCollectionsRepository : ICollectionsRepository
    {
        private readonly AppDbContext context;

        public EFCollectionsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteCollection(Guid Id)
        {
            this.context.Collections.Remove(new Collection() { Id = Id });
            this.context.SaveChanges();
        }

        public Collection GetCollection(Guid Id)
        {
            return this.context.Collections.FirstOrDefault(x => x.Id == Id);
        }

        public IQueryable<Collection> GetCollections()
        {
            return this.context.Collections;
        }

        public IQueryable<Collection> GetCollections(string searchString)
        {
            List<Collection> result = new List<Collection>();

            result.AddRange(this.context.Collections.Where(x => x.Title.Contains(searchString)
                                                                && searchString.Contains(x.Title)));
            result.AddRange(this.context.Collections.Where(x => x.Description.Contains(searchString)
                                                                && searchString.Contains(x.Description)));
            result.AddRange(this.context.Collections.Where(x => x.Theme != null && x.Theme.Contains(searchString)
                                                                && searchString.Contains(x.Theme)));

            return result.AsQueryable<Collection>();
        }

        public IQueryable<Collection> GetCollectionsFromUser(Guid userId)
        {
            return this.context.Collections.Where(x => x.UserId == userId);
        }

        public void SaveCollection(Collection entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }

            context.SaveChanges();
        }
    }
}
