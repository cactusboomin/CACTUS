using CACTUS.Domain;
using CACTUS.Domain.Entities;
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

        [Display(Name = "COLLECTIONS")]
        public List<Collection> Collections { get; set; }
    }
}
