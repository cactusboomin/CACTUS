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
        public CollectionsViewModel(DataManager manager)
        {
            this.Collections = manager.Collections.GetCollections().ToList();
        }

        public CollectionsViewModel(DataManager manager, Guid id)
        {
            this.Items = manager.Items
                    .GetItems()
                    .Where(i => i.CollectionId == id)
                    .Include(i => i.Collection)
                    .ToList();

            this.Collections = manager.Collections
                    .GetCollections()
                    .ToList();

            this.Collection = manager.Collections
                    .GetCollections()
                    .ToList()
                    .FirstOrDefault(c => c.Id == id);
        }

        [Display(Name = "COLLECTIONS")]
        public List<Collection> Collections { get; set; }

        [Display(Name = "COLLECTION")]
        public Collection Collection { get; set; }

        [Display(Name = "ITEMS")]
        public List<Item> Items { get; set; }
    }
}
