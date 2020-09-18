using CACTUS.Domain.Entities;
using CACTUS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.Abstract
{
    public interface ICollectionsRepository
    {
        IQueryable<Collection> GetCollections();
        IQueryable<Collection> GetCollectionsFromUser(string userId);
        IQueryable<Collection> GetCollections(string searchString);
        Collection GetCollection(Guid Id);
        void AddItem(Guid collectionId, Item item);
        void SaveTitleImage(FileModel file);
        void AddCollection(Collection entity);
        void SaveCollection(Collection entity);
        void DeleteCollection(Guid Id);
    }
}
