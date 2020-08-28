using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.Abstract
{
    public interface ICollectionsRepository
    {
        IQueryable<Collection> GetCollections();
        IQueryable<Collection> GetCollectionsFromUser(Guid userId);
        IQueryable<Collection> GetCollections(string searchString);
        Collection GetCollection(Guid Id);
        void SaveCollection(Collection entity);
        void DeleteCollection(Guid Id);
    }
}
