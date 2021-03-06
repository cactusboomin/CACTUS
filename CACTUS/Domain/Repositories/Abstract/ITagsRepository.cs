﻿using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.Abstract
{
    public interface ITagsRepository
    {
        void AddTag(Tag entity);
        IQueryable<Tag> GetTags();
        IQueryable<Tag> GetTags(string searchString);
        Tag GetTag(string Name);
        Tag GetTag(Guid id);
        void SaveTag(Tag entity);
    }
}
