using CACTUS.Domain;
using CACTUS.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            this.manager = manager;

            this.Item = manager.Items.GetItem(id);

            this.Comments = manager.Comments.GetComments(id).Include(c => c.User).ToList();

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

        public DataManager manager { get; set; }

        public List<Item> Items { get; set; }

        public Item Item { get; set; }

        public List<Comment> Comments { get; set; }

        public Collection Collection { get; set; }

        [Display(Name = "TITLE IMAGE")]
        public IFormFile TitleImage { get; set; }

        public string UserName { get; set; }
    }
}
