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
        public HomeViewModel(IEnumerable<Collection> collections, IEnumerable<Item> items, IEnumerable<Tag> tags)
        {
            this.Collections = collections.ToList();
            this.Items = items.ToList();
            this.Tags = tags.ToList();
        }

        public List<Collection> Collections { get; set; }

        public List<Item> Items { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
