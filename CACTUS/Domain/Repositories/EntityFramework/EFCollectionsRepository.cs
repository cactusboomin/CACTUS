﻿using CACTUS.Domain.Entities;
using CACTUS.Domain.Repositories.Abstract;
using CACTUS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Repositories.EntityFramework
{
    public class EFCollectionsRepository : ICollectionsRepository
    {
        private readonly AppDbContext context;

        public EFCollectionsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteCollection(Guid Id)
        {
            this.context.Items.RemoveRange(this.context.Items.Where(i => i.CollectionId == Id));
            this.context.Collections.Remove(new Collection() { Id = Id });

            this.context.SaveChanges();
        }

        public Collection GetCollection(Guid Id)
        {
            return this.context.Collections.Include(c => c.Items).FirstOrDefault(x => x.Id == Id);
        }

        public IQueryable<Collection> GetCollections()
        {
            return this.context.Collections;
        }

        public IQueryable<Collection> GetCollections(string searchString)
        {
            List<Collection> result = new List<Collection>();

            result.AddRange(this.context.Collections.Where(x => x.Title.Contains(searchString)
                                                                && searchString.Contains(x.Title)));
            result.AddRange(this.context.Collections.Where(x => x.Description.Contains(searchString)
                                                                && searchString.Contains(x.Description)));
            result.AddRange(this.context.Collections.Where(x => x.Theme != null && x.Theme.Contains(searchString)
                                                                && searchString.Contains(x.Theme)));

            return result.AsQueryable<Collection>();
        }

        public void AddItem(Guid collectionId, Item item)
        {
            var collection = this.context.Collections.FirstOrDefault(c => c.Id == collectionId);
            collection.Items.Add(item);
            SaveCollection(collection);
        }

        public IQueryable<Collection> GetCollectionsFromUser(string userId)
        {
            return this.context.Collections.Where(x => x.UserId == userId);
        }

        public void AddCollection(Collection entity)
        {
            this.context.Collections.Add(entity);

            this.context.SaveChanges();
        }

        public void SaveCollection(Collection entity)
        {
            context.Entry(entity).State = EntityState.Modified;

            this.context.SaveChanges();
        }
    }
}
