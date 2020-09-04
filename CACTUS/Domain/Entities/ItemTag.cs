﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public class ItemTag
    {
        public Guid ItemId { get; set; }
        public Item Item { get; set; }

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
