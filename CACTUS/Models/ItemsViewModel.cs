using CACTUS.Domain;
using CACTUS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class ItemsViewModel
    {
        public ItemsViewModel() { }

        public ItemsViewModel(DataManager manager)
        {
            this.Items = manager.Items.GetItems().ToList();
        }

        public ItemsViewModel(DataManager manager, Guid id)
        {
            this.Item = manager.Items.GetItem(id);

            this.Items = manager.Items.GetItems()
                .Include(i => i.Collection)
                .Include(i => i.ItemTags)
                .ThenInclude(t => t.Tag)
                .ToList();

            this.Item.Collection = this.Items.FirstOrDefault(i => i.Id == this.Item.Id).Collection;
        }

        public ItemsViewModel(IQueryable<Item> items)
        {
            this.Items = items.ToList();
        }

        public List<Item> Items { get; set; }

        public Item Item { get; set; }
    }
}
