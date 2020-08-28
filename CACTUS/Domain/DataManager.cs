using CACTUS.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain
{
    public class DataManager
    {
        public IItemsRepository Items { get; set; }
        public ICollectionsRepository Collections { get; set; }
        public ITagsRepository Tags { get; set; }

        public DataManager(IItemsRepository items, ICollectionsRepository collections, ITagsRepository tags)
        {
            this.Items = items;
            this.Collections = collections;
            this.Tags = tags;
        }
    }
}
