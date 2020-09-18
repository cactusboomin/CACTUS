using CACTUS.Domain;
using CACTUS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class CollectionsViewModel
    {
        public CollectionsViewModel() { }

        public CollectionsViewModel(DataManager manager)
        {
            this.Collections = manager.Collections.GetCollections().ToList();
        }

        public CollectionsViewModel(IQueryable<Collection> collections)
        {
            this.Collections = collections.ToList();
        }

        public CollectionsViewModel(DataManager manager, IQueryable<Item> items, Guid id)
        {
            this.Items = items.ToList();

            this.Collection = manager.Collections.GetCollection(id);

            this.UserId = Collection.UserId;
        }

        public CollectionsViewModel(DataManager manager, IQueryable<Item> items, Guid id, string userId)
        {
            this.Items = items.ToList();

            this.Collection = manager.Collections.GetCollections().FirstOrDefault(c => c.Id == id);
        }

        [Display(Name = "COLLECTIONS")]
        public List<Collection> Collections { get; set; }

        [Display(Name = "COLLECTION")]
        public Collection Collection { get; set; }

        [Display(Name = "ITEMS")]
        public List<Item> Items { get; set; }
        
        public string UserId { get; set; }
    }
}
