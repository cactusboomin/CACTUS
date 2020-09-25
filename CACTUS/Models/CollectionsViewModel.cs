using CACTUS.Domain;
using CACTUS.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

        public CollectionsViewModel(DataManager dataManager, UserManager<IdentityUser> userManager, IQueryable<Item> items, Guid id)
        {
            this.Items = items.ToList();

            this.Collection = dataManager.Collections.GetCollection(id);

            var user = userManager.FindByIdAsync(this.Collection.UserId).Result;
            if (user != null)
            {
                this.UserName = user.UserName;
            }
        }

        public CollectionsViewModel(DataManager manager, IQueryable<Item> items, Guid id, string userId)
        {
            this.Items = items.ToList();

            this.Collection = manager.Collections.GetCollections().FirstOrDefault(c => c.Id == id);
        }

        public List<Collection> Collections { get; set; }

        public Collection Collection { get; set; }

        public List<Item> Items { get; set; }

        public IFormFile TitleImage { get; set; }

        public string UserName { get; set; }
    }
}
