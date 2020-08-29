using CACTUS.Domain;
using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class ItemsViewModel
    {
        public ItemsViewModel(DataManager manager)
        {
            this.Items = manager.Items.GetItems().ToList();
        }

        public List<Item> Items { get; set; }
    }
}
