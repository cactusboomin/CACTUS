using CACTUS.Domain.Entities;
using CACTUS.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.EntityFramework
{
    public class EFItemsRepository : IItemsRepository
    {
        private readonly AppDbContext context;

        public EFItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteItem(Guid Id)
        {
            this.context.Items.Remove(new Item() { Id = Id });
        }

        public Item GetItem(Guid Id)
        {
            return this.context.Items.FirstOrDefault(x => x.Id == Id);
        }

        public IQueryable<Item> GetItems()
        {
            return this.context.Items;
        }

        public IQueryable<Item> GetItems(string searchString)
        {
            List<Item> result = new List<Item>();

            result.AddRange(this.context.Items.Where(x => x.Title.Contains(searchString)
                                                        && searchString.Contains(x.Title)));
            result.AddRange(this.context.Items.Where(x => x.Theme.Contains(searchString)
                                                        && searchString.Contains(x.Theme)));

            return result.AsQueryable<Item>();
        }

        public IQueryable<Item> GetItemsFromCollection(Guid collectionId)
        {
            return this.context.Items.Where(x => x.CollectionId == collectionId);
        }

        public IQueryable<Item> GetItemsFromUser(Guid userId)
        {
            return this.context.Items.Where(x => x.UserId == userId);
        }

        public void SaveItem(Item entity)
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
