using CACTUS.Domain;
using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class TagsViewModel
    {
        public TagsViewModel(DataManager manager)
        {
            this.Tags = manager.Tags.GetTags().ToList();
        }

        public List<Tag> Tags { get; set; }
    }
}
