using CACTUS.Domain;
using CACTUS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
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

        public TagsViewModel(DataManager manager, Guid id)
        {
            this.Tag = manager.Tags.GetTags()
                                .Include(t => t.ItemTags)
                                .ThenInclude(it => it.Item)
                                .FirstOrDefault(t => t.Id == id);
        }

        public TagsViewModel(IQueryable<Tag> tags)
        {
            this.Tags = tags.ToList();
        }

        public List<Tag> Tags { get; set; }

        public Tag Tag { get; set; }
    }
}
