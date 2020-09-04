using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.Abstract
{
    public interface IItemsRepository
    {
        IQueryable<Item> GetItems();
        IQueryable<Item> GetItemsFromUser(Guid userId);
        IQueryable<Item> GetItems(string searchString);
        Item GetItem(Guid Id);
        void SaveItem(Item entity);
        void DeleteItem(Guid Id);
    }
}
