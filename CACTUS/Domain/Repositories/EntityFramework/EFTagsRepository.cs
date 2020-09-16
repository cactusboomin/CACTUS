using CACTUS.Domain.Entities;
using CACTUS.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.EntityFramework
{
    public class EFTagsRepository : ITagsRepository
    {
        private readonly AppDbContext context;

        public EFTagsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddTag(Tag entity)
        {
            this.context.Tags.Add(entity);
            this.context.SaveChanges();
        }

        public Tag GetTag(string name)
        {
            return this.context.Tags.FirstOrDefault(x => 
                    x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }

        public Tag GetTag(Guid id)
        {
            return this.context.Tags.FirstOrDefault(x =>
                    x.Id == id);
        }

        public IQueryable<Tag> GetTags()
        {
            return this.context.Tags;
        }

        public IQueryable<Tag> GetTags(string searchString)
        {
            List<Tag> result = new List<Tag>();

            result.AddRange(this.context.Tags.Where(x => x.Name.Contains(searchString)
                                                        && searchString.Contains(x.Name)));

            return result.AsQueryable<Tag>();
        }
    }
}
