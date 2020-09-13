using CACTUS.Domain;
using CACTUS.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class UserViewModel
    {
        public UserViewModel(IdentityUser user)
        {
            this.User = user;
        }

        public UserViewModel(IdentityUser user, DataManager dataManager)
        {
            this.User = user;

            this.Collections = dataManager.Collections.GetCollectionsFromUser(user.Id).ToList();
            this.Items = dataManager.Items.GetItemsFromUser(user.Id).ToList();
        }

        public IdentityUser User { get; set; }

        public List<Collection> Collections { get; set; }
        public List<Item> Items { get; set; }
    }
}
