using CACTUS.Domain;
using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(DataManager manager)
        {
            this.Collections = manager.Collections.GetCollections().ToList();
            this.Items = manager.Items.GetItems().ToList();
            this.Tags = manager.Tags.GetTags().ToList();
        }

        [Display(Name = "COLLECTIONS")]
        public List<Collection> Collections { get; set; }

        [Display(Name = "ITEMS")]
        public List<Item> Items { get; set; }

        [Display(Name = "TAGS")]
        public List<Tag> Tags { get; set; }
    }
}
